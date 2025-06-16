using System;
using static System.Windows.Forms.DataFormats;

namespace Assignment_4
{
    public partial class MainForm : Form
    {
        //Temporary variables
        private static int maxNumOfIngredients = 50;

        private RecipeManager recipeManager = new RecipeManager(maxNumOfIngredients);

        private Recipe currRecipe = new Recipe(maxNumOfIngredients);

        public MainForm()
        {
            InitializeComponent();
            UpdateRecipeList();

            cmbCategory.DataSource = Enum.GetValues(typeof(Category));
        }

        //Update the recipe list every time something is changed
        private void UpdateRecipeList()
        {
            lstRecipes.Items.Clear();

            for (int i = 0; i < recipeManager.GetNumberOfRecipes(); i++)
            {
                Recipe recipe = recipeManager.GetRecipeAtIndex(i);
                if (recipe != null)
                {
                    string item = String.Format("{0,-20} {1,-15} {2,-10}", recipe.Name, recipe.FoodCategory, recipe.NumberOfIngredients);
                    lstRecipes.Items.Add(item);
                }
            }
        }

        //Validates all input from both forms. Add errors if something is wrong.
        public bool ValidateAllInput(out List<string> errorMessages)
        {
            errorMessages = new List<string>();

            bool nameValid = ValidateRecipeName(out string nameError);
            if (!nameValid) errorMessages.Add(nameError);

            bool categoryValid = ValidateCategory(out string categoryError);
            if (!categoryValid) errorMessages.Add(categoryError);

            bool descriptionValid = ValidateDescription(out string descriptionError);
            if (!descriptionValid) errorMessages.Add(descriptionError);

            bool ingredientsValid = ValidateIngredients(out string ingredientsError);
            if (!ingredientsValid) errorMessages.Add(ingredientsError);

            return nameValid && categoryValid && ingredientsValid && descriptionValid;
        }

        private bool ValidateRecipeName(out string errorMessage)
        {
            string recipeName = txtRecipeName.Text.Trim();
            if (string.IsNullOrEmpty(recipeName))
            {
                txtRecipeName.Focus();
                errorMessage = "name";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private bool ValidateCategory(out string errorMessage)
        {
            if (cmbCategory.SelectedItem == null)
            {
                cmbCategory.Focus();
                errorMessage = "category";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private bool ValidateDescription(out string errorMessage)
        {
            if (currRecipe != null && string.IsNullOrEmpty(currRecipe.Description))
            {
                errorMessage = "description";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private bool ValidateIngredients(out string errorMessage)
        {
            if (currRecipe.CurrentNumberOfIngredients() == 0)
            {
                errorMessage = "ingredients";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private void SetAll()
        {
            currRecipe.Name = txtRecipeName.Text;
            currRecipe.FoodCategory = (Category)cmbCategory.SelectedItem;

            //FIX: Always clone the recipe before adding it,
            //meaning there are never several references to the same object.
            Recipe clone = currRecipe.Clone();

            recipeManager.addRecipe(clone);
            currRecipe = new Recipe(maxNumOfIngredients);

            UpdateRecipeList();
        }

        //Open FormRecipeDetails form
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            OpenRecipeDetails();
        }

        //Add a new recipe and check for errors
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (!ValidateAllInput(out List<string> errorMessages) && currRecipe != null)
            {
                string allErrors = string.Join("\n", errorMessages);
                MessageBox.Show(text: allErrors, "Not all fields were added.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SetAll();
                txtRecipeName.Clear();
            }
        }

        //Delete selected recipe
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstRecipes.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Select an item first!", "Error");
            }
            else
            {
                recipeManager.deleteRecipe(index);
                ClearInput(); //FIX: Ensure that input fields are not filled with data from a deleted object
                UpdateRecipeList();

            }

        }

        //Change name and category of selected object
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!ValidateRecipeName(out string nameError) || !ValidateCategory(out string categoryError))
            {
                MessageBox.Show(text: "Please fill in all required fields.", "Not all fields were added.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int index = lstRecipes.SelectedIndex;
                currRecipe = recipeManager.GetRecipeAtIndex(index);

                if (currRecipe != null) //FIX: Added checking if currRecipe is null to avoid null exceptions
                {
                    lblRecipeInstructions.Text = currRecipe.Description;
                    currRecipe.Name = txtRecipeName.Text.Trim();
                    currRecipe.Description = lblRecipeInstructions.Text.Trim();
                    currRecipe.FoodCategory = (Category)cmbCategory.SelectedItem; 
                    OpenRecipeDetails(); //FIX: The change button now opens the RecipeDetails form as well
                }

                UpdateRecipeList();
            }
        }

        /// <summary>
        /// Open recipe details form to add or change recipes
        /// </summary>
        public void OpenRecipeDetails()
        {
            FormRecipeDetails formRecipeDetails = new FormRecipeDetails(currRecipe);
            formRecipeDetails.ShowDialog();
        }

        //Clear all input fields.
        //Do not change any selected recipe from the list of recipes
        private void BtnClearInput_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        //FIX: Ensures that the input fields are reset for a new recipe entry without affecting added recipes.
        public void ClearInput()
        {
            currRecipe = new Recipe(maxNumOfIngredients); //Creates a new Recipe object to avoid null exceptions

            txtRecipeName.Clear();
            lblRecipeInstructions.Text = "";
            cmbCategory.SelectedIndex = -1;
            pctImage.Image = null;
            lstRecipes.SelectedIndex = -1;
        }

        //Update user interface when a new recipe is selected
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstRecipes.SelectedIndex;
            if (index >= 0 && currRecipe != null)
            {
                //Get the current index
                currRecipe = recipeManager.GetRecipeAtIndex(index);

                //Show description, name and selected item
                lblRecipeInstructions.Text = currRecipe.Description;
                txtRecipeName.Text = currRecipe.Name;
                cmbCategory.SelectedItem = currRecipe.FoodCategory;

                //Show image if available
                if (currRecipe.RecipeImage != null)
                {
                    pctImage.Image = currRecipe.RecipeImage;
                }
                else
                {
                    pctImage.Image = null;
                }
            }
        }

        //Add an image and save it to the recipe. This is optional
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Set filter for images
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*",
                Title = "Select an Image"
            };

            // Show the OpenFileDialog and check if a file is selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pctImage.Image = Image.FromFile(imagePath);

                pctImage.SizeMode = PictureBoxSizeMode.StretchImage;

                //Save image to current recipe
                currRecipe.RecipeImage = pctImage.Image;

            }
        }
    }
}
