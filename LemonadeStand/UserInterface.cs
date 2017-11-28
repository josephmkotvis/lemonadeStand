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
        Inventory inventory;
        Store store;
        Day day;
        Game game;

        // constructor

        //methods

        public void DisplayPlayer1NameOption()
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
            Console.WriteLine("This is how to play blah blah");
        }
        public void DisplayPlayer1Inventory()
        {
            Console.WriteLine("Your inventory consists of " + Environment.NewLine + + inventory.item1Amount + " " + inventory.item1name + "(s), " + Environment.NewLine + +  inventory.item2Amount + " "  + inventory.item2name + "(s), " + Environment.NewLine + + inventory.item3Amount + " " + inventory.item3name + "(s), " + Environment.NewLine + + inventory.item4Amount + " " + inventory.item4name + "(s). ");
        }
        public void DisplayPlayer1Money()
        {
            Console.WriteLine(player1.name + "currently has " + player1.money + " in the piggybank" );
        }
        public void DisplayStoreOptions()
        {
            Console.WriteLine( " The store has several available buying options. Some of these options are : " + Environment.NewLine + "1)" + store.item1Name + "(s) for " + store.item1Cost + " each." + Environment.NewLine + "2)" + store.item2Name + "(s) for " + store.item2Cost + " each." + Environment.NewLine + "3)" + store.item3Name + "(s) for " + store.item3Cost + " each." + Environment.NewLine + "4)" + store.item4Name + "(s) for " + store.item4Cost + " each." + Environment.NewLine + " Select the number accordingly (1-4) or press 5 to look at the bundles available for these options.");
        } 
        public void DisplayItemBundles()
        {
            Console.WriteLine(" The bundles come in sets of " + Environment.NewLine + + store.bundleAmount1 +" for " + (100 * store.bundle1Discount) + "% off, " + Environment.NewLine + +store.bundleAmount2 + " for " + (100 * store.bundle2Discount) + "% off, " + Environment.NewLine + +store.bundleAmount3 + " for " + (100 * store.bundle3Discount) + "% off." + Environment.NewLine + "Choose the number accordingly to wchich item you would want to see specific prices for:" + Environment.NewLine +" 1)" + store.item1Name + ","+ Environment.NewLine + "2)" + store.item2Name + "," + Environment.NewLine + "3)" + store.item3Name + "," + Environment.NewLine + "4)" + store.item4Name + "."  );
        }
        public void DisplayItem1Bundles()
        {
            Console.WriteLine(" You have chosen to look at the bundle prices for the " + store.item1Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" +store.bundleAmount1 + "pack for " + store.item1BundleCost1 + "" +Environment.NewLine +"2)" +store.bundleAmount2 + "pack for " +store.item1BundleCost2 +"" + Environment.NewLine +"3" + store.bundleAmount3 + " pack for " + store.item1BundleCost3 +".");
        }
        public void DisplayItem2Bundles()
        {
            Console.WriteLine(" You have chosen to look at the bundle prices for the " + store.item2Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" + store.bundleAmount1 + "pack for " + store.item2BundleCost1 + "" + Environment.NewLine + "2)" + store.bundleAmount2 + "pack for " + store.item2BundleCost2 + "" + Environment.NewLine + "3" + store.bundleAmount3 + " pack for " + store.item2BundleCost3 + ".");
        }
        public void DisplayItem3Bundles()
        {
            Console.WriteLine(" You have chosen to look at the bundle prices for the " + store.item3Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" + store.bundleAmount1 + "pack for " + store.item3BundleCost1 + "" + Environment.NewLine + "2)" + store.bundleAmount2 + "pack for " + store.item3BundleCost2 + "" + Environment.NewLine + "3" + store.bundleAmount3 + " pack for " + store.item3BundleCost3 + ".");
        }
        public void DisplayItem4Bundles()
        {
            Console.WriteLine(" You have chosen to look at the bundle prices for the " + store.item4Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" + store.bundleAmount1 + "pack for " + store.item4BundleCost1 + "" + Environment.NewLine + "2)" + store.bundleAmount2 + "pack for " + store.item4BundleCost2 + "" + Environment.NewLine + "3" + store.bundleAmount3 + " pack for " + store.item4BundleCost3 + ".");
        }

        public void DisplayDay()
        {
            Console.WriteLine("You are on day " + day.currentDay + " out of " + game.endDate + "s." );
        }
        public void DisplayWeatherToday()
        {
            Console.WriteLine( "The current weather is" + game.currentWeather + ".");
        }
        public void DisplayWeatherWeek()
        {
            //Displays what the weather is that week
        }
        public void DisplayItem1RecipeOption()
        {
            Console.WriteLine("How many " + inventory.item1name + " out of " + inventory.item1Amount + " would you like to use? (0-" + inventory.item1Amount + ")");
        }
        public void DisplayItem2RecipeOption()
        {
            Console.WriteLine("How many " + inventory.item2name + " out of " + inventory.item2Amount + " would you like to use? (0-" + inventory.item2Amount + ")");
        }
        public void DisplayItem3RecipeOption()
        {
            Console.WriteLine("How many " + inventory.item3name + " out of " + inventory.item3Amount + " would you like to use? (0-" + inventory.item3Amount + ")");
        }
        public void DisplayItem4RecipeOption()
        {
            Console.WriteLine("How many " + inventory.item4name + " out of " + inventory.item4Amount + " would you like to use? (0-" + inventory.item4Amount + ")");
        }
        public void DisplayCostOptions()
        {
            Console.WriteLine(" How much would you like to charge for each one of your products? (0$ - 100$)");
        }
        public void DisplayRoundStart()
        {
            Console.WriteLine("Your recipe consists of: " + Environment.NewLine + +game.item1RecipeAmount + " " + inventory.item1name + "(s)." + Environment.NewLine + +game.item2RecipeAmount + " " + inventory.item2name + "(s)." + Environment.NewLine + +game.item3RecipeAmount + " " + inventory.item3name + "(s).");
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
