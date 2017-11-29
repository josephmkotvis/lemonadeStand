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
        public static string name;
        Game game;

        // make wallet class
        //wallet says I dont have enough money
        // have store say it wont take it without money
        public string input;
        public decimal item1RecipeAmount;
        public decimal item2RecipeAmount;
        public decimal item3RecipeAmount;

       

        //constructor


        //methods
        public string SetPlayerInput()
        {
            input = Console.ReadLine();
            return input;
        }
        void ChoosePlayerName()
        {
            UserInterface.DisplayPlayerNameOption();
            SetPlayerInput();
            name = input;
        }
        void ChooseEndDate()
        {
            UserInterface.DisplayEndDateOption();
            SetPlayerInput();
            Convert.ToInt32(input);
            Game.CheckEndDateChoie();
        }
        void CheckIfReadyToContinueToSelling()
        {
            UI.DisplayContinueToSellingOptions();
            UI.GetUserInput();
            switch (UI.userInput)
            {
                case "1":
                    ChooseBuyingOptions();
                    break;
                case "2":
                    UI.DisplayContinueToSelling();
                    break;
            }
        }
    }
}
