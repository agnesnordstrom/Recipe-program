using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class RecipeManager
    {
        private int numOfElems = 0;

        private string[] recipes = new string[200];

        public Recipe[] recipeList;

        private Recipe newRecipe;

        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe [maxNumOfElements];
        }

        //Add recipe to the first null value of the array
        public bool addRecipe(Recipe newRecipe)
        {
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                {
                    recipeList[i] = newRecipe;
                    numOfElems++;
                    return true;
                }
            }
            return false;

        }
        public void deleteRecipe(int index)
        {
            recipeList[index] = null;
            numOfElems--;
            MoveElementsOneStepToLeft(index);
        }
            
            private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < recipeList.Length; i++)
            {
                recipeList[i - 1] = recipeList[i]; //move 1 step to left
                recipeList[i] = null; //empty its place
            }
        }

        public int GetNumberOfRecipes()
        {
            int numberOfRecipes = 0;

            for (int i = 0; i < recipeList.Length; i++)
            {
                numberOfRecipes++ ;
            }

            return numberOfRecipes;
        }

        public Recipe GetRecipeAtIndex(int index)
        {

            if (index >= 0 && index < recipeList.Length && recipeList[index] != null)
            {
                return recipeList[index];
                
            }
            return null; //If index is outside of array, return null. It breaks without this
        }


    }
}
