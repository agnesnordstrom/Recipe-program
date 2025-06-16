using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{


    internal class Recipe
    {
        private Category foodCategory;
        private string name;
        private string description;
        private string[] ingredients;
        private Image recipeImage;

        private int maxNumOfIngredients;
        private int numberOfIngredients;

        public Recipe(int maxIngredients)
        {
            maxNumOfIngredients = maxIngredients;
            DefaultValues();
        }

        public void DefaultValues()
        {
            foodCategory = Category.Other;
            name = String.Empty;
            description = String.Empty;
            ingredients = new string[maxNumOfIngredients];

            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i] = null;
            }
        }

        //Parameters
        public Image RecipeImage { get { return recipeImage; } set { recipeImage = value; } }
        public Category FoodCategory { get { return foodCategory; } set { foodCategory = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int MaxNumberOfIngredients { get { return maxNumOfIngredients; } }

        public int NumberOfIngredients {  get { return  numberOfIngredients; } }

        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; } // Replace the entire array
        }

        // Add and change ingredients
        public bool AddIngredients(string input)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] == null)  // Add ingredient to first empty position
                {
                    ingredients[i] = input;
                    numberOfIngredients++;
                    return true;
                }
            }
            return false;  // Return false the array is full
        }

        public bool ChangeIngredientAt(int index, string value)
        {
            if (index >= 0 && index < ingredients.Length && ingredients[index] != null)
            {
                ingredients[index] = value; 
                return true;
            }
            return false;  // Return false if the index is invalid or the position is empty
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < ingredients.Length;
        }

        public int CurrentNumberOfIngredients()
        {
            int count = 0;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] != null)
                {
                    count++;  // Count only non-null ingredients
                }
            }
            return count;
        }

        public void DeleteIngredientAt(int index)
        {
            if (index >= 0 && index < ingredients.Length && ingredients[index] != null)
            {
                ingredients[index] = null;
                numberOfIngredients--;
                MoveElementsOneStepToLeft(index);
            }
        }
        
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < ingredients.Length; i++)
            {
                ingredients[i - 1] = ingredients[i]; //move 1 step to left
                ingredients[i] = null; //empty its place
            }
        }

        public string GetIngredientsString()
        {
            return string.Join(", ", ingredients.Where(i => i != null));  // Return a comma-separated list of non-null ingredients
        }

        /// <summary>
        /// Clones recipes by creating a new recipe object.
        /// </summary>
        /// <returns>A clone of the current recipe</returns>
        public Recipe Clone()
        {
            Recipe clone = new Recipe(maxNumOfIngredients)
            {
                Name = this.Name,
                Description = this.Description,
                FoodCategory = this.FoodCategory,
                RecipeImage = this.RecipeImage != null ? (Image)this.RecipeImage.Clone() : null
            };

            for (int i = 0; i < this.ingredients.Length; i++)
            {
                clone.ingredients[i] = this.ingredients[i];
            }

            clone.numberOfIngredients = this.numberOfIngredients;

            return clone;
        }
    }
}