using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables
        public string name;
        public decimal money = 100;
        public decimal item1RecipeAmount;
        public decimal item2RecipeAmount;
        public decimal item3RecipeAmount;
        public int chosenEndDate;


        //constructor
        public Player(string name)
        {
            this.name = name;
        }


        //methods


    }
}
