using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        // member variables
        public string userInput;
        Player player1;

        // constructor

        //methods

        public void DisplayNameOption()
        {
            Console.WriteLine("What is " + player1.name + "'s name?");
        }
        public string GetUserInput()
        {
            userInput = Console.ReadLine();
            return userInput;
        }
        public void DisplayFaq()
        {
            // Displays rules and how to play
        }
        public void DisplayInventory()
        {
            // Shows items in inventory (Lemons,Sugar,Ice & Cups)
        }
        public void DisplayMoney()
        {
            // Displays money in wallet
        }
        public void DisplayStoreOptions()
        {
            // Displays what you can buy in store
        } 
        public void DisplayItemBundles()
        {
            // Displays the bundles you can buy associated with price
        }
        public void DisplayItemBundle1()
        {
            // Displays the first bundle available
        }
        public void DisplayItemBundle2()
        {
            //Displays the second bundle available.
        }

        public void DisplayDay()
        {
            //Displays what day it is
        }
        public void DisplayWeatherToday()
        {
            //Displays what the weather is that day
        }
        public void DisplayWeatherWeek()
        {
            //Displays what the weather is that week
        }
        public void DisplayRecipeOptions()
        {
            // Displays your option to toggle lemons,sugar and ice.
        }
        public void DisplayCostOptions()
        {
            //Display options to change the cost of your money
        }
        public void DisplayRoundStart()
        {
            //Say your begining round with recipe x and $y, weather is z. 
        }
        public void DisplayRoundResults()
        {
            // Display the results of the round
        }
        public void DisplaySalesResults()
        {
            //Display how many cups were sold.
        }
        public void DisplayInventoryChanges()
        {
            // Display how much the inventory change
        }
        public void DisplayMoneyChanges()
        {
            // Display how the change in money
        }
        public void DisplayCustomerReviews()
        {
            // Will display the reviews of your lemonade at the end of the game
        }
        public void DisplayRoundScore()
        {
            // Displays how well you did based on amount of cups sold.
        }
        public void DisplayCustomerAmount()
        {
            //Displays how many customers there were
        }
        public void DisplayAfterGameOptions()
        {
            //Display options aftergame
        }
        public void DisplayItemLost()
        {
            //Displays that you lost items.
        }
        public void DisplayItemGained()
        {
            //Displays tha you gained items.
        }
        public void DisplayDaysLeft()
        {
            // Displays how many days are left in the game
        }
        public void DisplayTips()
        {
            //Displays if anyoen tipped
        }
        public void DisplayCustomerSatisfaction()
        {
            //Displays how many customers were satisfied
        }
        public void DisplaysReputation()
        {
            //Displays the amount of people that could be buying compared to how many did
        }
        public void DisplayEndDateOption()
        {
            Console.WriteLine("How many days would you like to play? 1-100");
            
        }
    }
}
