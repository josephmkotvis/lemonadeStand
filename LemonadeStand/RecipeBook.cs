using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class RecipeBook
    {
        public double playerRecipeChangeNumber;
        public double item1RecipeAmount;
        public double item2RecipeAmount;
        public double item3RecipeAmount;
        public double item4RecipeAmount;
        public double cost;
        public void AddToItem1RecipeAmount()
        {
            item1RecipeAmount += playerRecipeChangeNumber;
        }
        public void AddToItem2RecipeAmount()
        {
            item2RecipeAmount += playerRecipeChangeNumber;
        }
        public void AddToItem3RecipeAmount()
        {
            item3RecipeAmount += playerRecipeChangeNumber;
        }
        public void AddToItem4RecipeAmount()
        {
            item4RecipeAmount += playerRecipeChangeNumber;
        }
    }
}
