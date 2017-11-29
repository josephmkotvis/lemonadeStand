using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        // member variables
  
        // move to playerinput
        

        // make UI into a static

        // constructor

        public static void DisplayPlayerNameOption()
        {
            Console.WriteLine(Environment.NewLine + "What would you like your name to be?");
        }

        public static void DisplayFaq()
        {
            Console.WriteLine(Environment.NewLine + "This is how to play blah blah");
        }
        public static void DisplayPlayer1Inventory()
        {
            Console.WriteLine(Environment.NewLine + "" + Player.name + "'s inventory consists of: " + Environment.NewLine + + Inventory.item1Amount + " " + inventory.item1name + "(s), " + Environment.NewLine + +  inventory.item2Amount + " "  + inventory.item2name + "(s), " + Environment.NewLine + + inventory.item3Amount + " " + inventory.item3name + "(s), " + Environment.NewLine + + inventory.item4Amount + " " + inventory.item4name + "(s). ");
        }
        public static void DisplayPlayer1Money()
        {
            Console.WriteLine(Environment.NewLine + Player.name + " currently has " + PiggyBank.money + " in the piggybank" );
        }
        public void DisplayStoreOptions()
        {
            Console.WriteLine(Environment.NewLine + "The store has several available buying options. Select the number accordingly (1-5) to these options are : " + Environment.NewLine + "1)" + store.item1Cost + "$ for each "+ store.item1Name +"." + Environment.NewLine + "2)" + store.item2Cost + "$ for each " + store.item2Name + "." + Environment.NewLine + "3)" + store.item3Cost + "$ for each " + store.item3Name + "." + Environment.NewLine + "4)" + store.item4Cost + "$ for each " + store.item4Name + "." + Environment.NewLine  + "5)Look at the bundles available for these items." + Environment.NewLine + "6)To continue.");
        } 
        public void DisplayIncorrectChoice()
        {
            Console.WriteLine(Environment.NewLine + "You have selected an incorrect choice, please try again");
        }
        public void DisplayFinishBuyingOption()
        {
            Console.WriteLine(Environment.NewLine + "Select the number that matches your decision:" + Environment.NewLine + "1)Continue Buying" + Environment.NewLine + "2)Finish Buying" );
        }
        public void DisplayItemBundles()
        {
            Console.WriteLine(Environment.NewLine + "The bundles come in sets of " + Environment.NewLine + + store.bundle1Amount +" for " + (100 * store.bundle1Discount) + "% off, " + Environment.NewLine + + store.bundle2Amount + " for " + (100 * store.bundle2Discount) + "% off, " + Environment.NewLine + +store.bundle3Amount + " for " + (100 * store.bundle3Discount) + "% off." + Environment.NewLine + "Choose the number accordingly to which item you would want to see specific prices for:" + Environment.NewLine +"1)" + store.item1Name + ","+ Environment.NewLine + "2)" + store.item2Name + "," + Environment.NewLine + "3)" + store.item3Name + "," + Environment.NewLine + "4)" + store.item4Name + "," + Environment.NewLine + "5)To return to buying the items individually," + Environment.NewLine + "6)To continue.");
        }
        public void DisplayItem1Bundles()
        {
            Console.WriteLine(Environment.NewLine + "You have chosen to look at the bundle prices for the " + store.item1Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" +store.bundle1Amount + " pack for " + store.item1Bundle1Cost + "$," +Environment.NewLine +"2)" +store.bundle2Amount + " pack for " +store.item1Bundle2Cost +"$," + Environment.NewLine +"3)" + store.bundle3Amount + " pack for " + store.item1Bundle3Cost +"$," + Environment.NewLine + "4)Return to choosing which item for bundle options," + Environment.NewLine + "5)To continue.");
        }
        public void DisplayItem2Bundles()
        {
            Console.WriteLine(Environment.NewLine + "You have chosen to look at the bundle prices for the " + store.item2Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" + store.bundle1Amount + " pack for " + store.item2Bundle1Cost + "$," + Environment.NewLine + "2)" + store.bundle2Amount + " pack for " + store.item2Bundle2Cost + "$," + Environment.NewLine + "3)" + store.bundle3Amount + " pack for " + store.item2Bundle3Cost + "$," + Environment.NewLine + "4)Return to choosing which item for bundle options," + Environment.NewLine + "5)To continue.");
        }
        public void DisplayItem3Bundles()
        {
            Console.WriteLine(Environment.NewLine + "You have chosen to look at the bundle prices for the " + store.item3Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" + store.bundle1Amount + " pack for " + store.item3Bundle1Cost + "$," + Environment.NewLine + "2)" + store.bundle2Amount + " pack for " + store.item3Bundle2Cost + "$," + Environment.NewLine + "3)" + store.bundle3Amount + " pack for " + store.item3Bundle3Cost + "$," + Environment.NewLine + "4)Return to choosing which item for bundle options," + Environment.NewLine + "5)To continue.");
        }
        public void DisplayItem4Bundles()
        {
            Console.WriteLine(Environment.NewLine + "You have chosen to look at the bundle prices for the " + store.item4Name + "." + Environment.NewLine + "Choose the number accordinlgy to the bundle you would like to purhcase:" + Environment.NewLine + "1)" + store.bundle1Amount + " pack for " + store.item4Bundle1Cost + "$," + Environment.NewLine + "2)" + store.bundle2Amount + " pack for " + store.item4Bundle2Cost + "$," + Environment.NewLine + "3)" + store.bundle3Amount + " pack for " + store.item4Bundle3Cost + "$," + Environment.NewLine + "4)Return to choosing which item for bundle options," + Environment.NewLine + "5)To continue.");
        }

        public void DisplayDay()
        {
            Console.WriteLine(Environment.NewLine + "You are on day " + day.currentDay + " out of " + player1.chosenEndDate + "." );
        }
        public void DisplayWeatherToday()
        {
            Console.WriteLine(Environment.NewLine + "The current weather is" + day.currentWeather + ".");
        }
        public void DisplayWeatherWeek()
        {
            //Displays what the weather is that week
                // make a generator for the day in 7th spot
                //then everytime the round ends just make
                //weathernextday become current weather
                //weather2ndDay become weathernext day
                // then do that until the seventh day where that will be randomly generated/
        }
        public void DisplayItem1RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + inventory.item1name + " out of " + inventory.item1Amount + " would you like to use? (0-" + inventory.item1Amount + ")");
        }
        public void DisplayItem2RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + inventory.item2name + " out of " + inventory.item2Amount + " would you like to use? (0-" + inventory.item2Amount + ")");
        }
        public void DisplayItem3RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + inventory.item3name + " out of " + inventory.item3Amount + " would you like to use? (0-" + inventory.item3Amount + ")");
        }
        public void DisplayItem4RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + inventory.item4name + " out of " + inventory.item4Amount + " would you like to use? (0-" + inventory.item4Amount + ")");
        }
        public void DisplayCostOptions()
        {
            Console.WriteLine(Environment.NewLine + " How much would you like to charge for each one of your products? (0$ - 100$)");
        }
        public void DisplayRoundStart()
        {
            Console.WriteLine(Environment.NewLine + "Your recipe consists of: " + Environment.NewLine + +player1.item1RecipeAmount + " " + inventory.item1name + "(s)." + Environment.NewLine + +player1.item2RecipeAmount + " " + inventory.item2name + "(s)." + Environment.NewLine + +player1.item3RecipeAmount + " " + inventory.item3name + "(s).");
        }
        public void DisplayRoundResults()
        {

            // Display the results of the round
        }
        public void DisplaySalesResults()
        {
            //Display how many cups were sold
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
        public static void DisplayEndDateOption()
        {
            Console.WriteLine(Environment.NewLine + "How many days would you like to play? 1-50.");
        }
        public void DisplayPressToContinue()
        {
            Console.WriteLine(Environment.NewLine + "Press any button to continue.");
        }
        public void DisplayLackOfMoney()
        {
            Console.WriteLine(Environment.NewLine + "You do not have enough funds for this purchase.");
        }
        public void DisplayContinueToSelling()
        {
            Console.WriteLine(Environment.NewLine + "Now the round will begin.");
        }
        public void DisplayContinueToSellingOptions()
        {
            Console.WriteLine(Environment.NewLine + "Would you like to begin selling your product?" + Environment.NewLine + " 1)Continue prepping" + Environment.NewLine + "2)Begin Selling.");
        }
    }
}
