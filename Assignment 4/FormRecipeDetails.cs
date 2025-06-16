using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class FormRecipeDetails : Form
    {
        private Recipe currRecipe;

        internal FormRecipeDetails(Recipe recipe)
        {
            InitializeComponent();
            currRecipe = recipe;
            UpdateIngredientsList();
            txtDescription.Text = currRecipe.Description;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            currRecipe.Description = txtDescription.Text;
            UpdateIngredientsList();

            this.Close();
        }


        private void UpdateIngredientsList()
        {
            lstIngredients.Items.Clear();

            for (int i = 0; i < currRecipe.NumberOfIngredients; i++)
            {
                string ingredient = currRecipe.Ingredients[i];

                if (!string.IsNullOrEmpty(ingredient))
                {
                    lstIngredients.Items.Add(ingredient);
                }
            }
            //Update the NumberOfIngredients label
            lblNumberOfIngredients.Text = currRecipe.NumberOfIngredients.ToString();
        }


        //Add new ingredient
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ingredient = txtIngredient.Text.Trim();

            if (!string.IsNullOrEmpty(ingredient))
            {
                currRecipe.AddIngredients(ingredient);
                UpdateIngredientsList();
                txtIngredient.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateIngredientsList();
            txtIngredient.Clear();
        }

        //Close the form without clearing or saving data
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Delete ingredient at chosen index
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Select an item first!", "Error");
            }
            else
            {
                currRecipe.DeleteIngredientAt(index);
                UpdateIngredientsList();
            }

        }

        //Edit ingredient at chosen index
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please select an ingredient to edit.", "Error");
                return;
            }

            string newIngredient = txtIngredient.Text.Trim();

            if (string.IsNullOrEmpty(newIngredient))
            {
                MessageBox.Show("Please enter the new ingredient text.", "Error");
                return;
            }

            currRecipe.ChangeIngredientAt(index, newIngredient);

            UpdateIngredientsList();
            txtIngredient.Clear();
        }
    }
    
}