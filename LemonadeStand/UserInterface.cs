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
        Player player;
        Store store;
        Day day1;
        Day day2;
        Day day3;
        Day day4;
        Day day5;
        Day day6;
        Day day7;
        // make UI into a static

        // constructor
        public UserInterface(Player player,Store store,Day day1, Day day2, Day day3, Day day4, Day day5, Day day6, Day day7)
        {
            this.player = player;
            this.store = store;
            this.day1 = day1;
            this.day2 = day2;
            this.day3 = day3;
            this.day4 = day4;
            this.day5 = day5;
            this.day6 = day6;
            this.day7 = day7;
        }
        //methods
        public  void ClearConsoleLog()
        {
            Console.Clear();
        }
        public void DisplayRoundInfo()
        {
            DisplayDay();
            DisplayWeather();
            DisplayWeatherWeek();
            DisplayPlayer1Money();
            DisplayPlayer1Inventory();
        }
        public  void NotifyLackOfMoney()
        {
            DisplayLackOfMoney();
            DisplayPressToContinue();
        }
        public  void DisplayIncorrectOption()
        {
            ClearConsoleLog();
            DisplayIncorrectChoice();
            DisplayPressToContinue();
        }
        public void DisplayPlayerNameOption()
        {
            Console.WriteLine(Environment.NewLine + "What is " + player.name + "'s name?");
        }
        public string GetUserInput()
        {
            userInput = Console.ReadLine();
            return userInput;
        }
        public void DisplayFaq()
        {
            Console.WriteLine(Environment.NewLine + "This is how to play blah blah");
        }
        public void DisplayPlayer1Inventory()
        {
            Console.WriteLine(Environment.NewLine + "" + player.name + "'s inventory consists of: " + Environment.NewLine + + player.inventory.item1Amount + " " + player.inventory.item1name + "(s), " + Environment.NewLine + +  player.inventory.item2Amount + " "  + player.inventory.item2name + "(s), " + Environment.NewLine + + player.inventory.item3Amount + " " + player.inventory.item3name + "(s), " + Environment.NewLine + + player.inventory.item4Amount + " " + player.inventory.item4name + "(s). ");
        }
        public void DisplayPlayer1Money()
        {
            Console.WriteLine(Environment.NewLine + player.name + " currently has " + player.piggyBank.money + "$ in the piggybank" );
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
            Console.WriteLine(Environment.NewLine + "Select the number that matches your decision:" + Environment.NewLine + "1)Finish Buying" + Environment.NewLine + "2)Continue Buying" );
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
            Console.WriteLine(Environment.NewLine + "You are on day " + day1.currentDay + " out of " + player.chosenEndDate + "." );
        }
        public void DisplayWeather()
        {
            Console.WriteLine("Today's weather is " + Environment.NewLine + "" + day1.currentWeatherType + "" + Environment.NewLine + "Air Temperature: " + day1.currentAirTemperature + ""  + Environment.NewLine + "Humidity: " + day1.currentHumidity + "" +Environment.NewLine + "WindSpeed: " + day1.currentWindSpeed + "" + Environment.NewLine +  "Precipitation: " + day1.currentPrecipitation);    
        }
        public void DisplayWeatherWeek()
        {
            Console.WriteLine(Environment.NewLine + "The weather for the rest of the week is as follows:" + Environment.NewLine + "2)" + day1.currentWeatherType + "" + Environment.NewLine + "3)" + day2.currentWeatherType + "" + Environment.NewLine + "4)" + day3.currentWeatherType + "" + Environment.NewLine + "5)" + day4.currentWeatherType + "" + Environment.NewLine + "6)" + day5.currentWeatherType + "" + Environment.NewLine + "7)" + day6.currentWeatherType + "" + Environment.NewLine + "8)" + day7.currentWeatherType);

        }
        public void DisplayContinuationToRecipe()
        {
            Console.WriteLine(Environment.NewLine + "The next step before you start selling your product is to create your recipe." + Environment.NewLine + "We will make it item by item." + Environment.NewLine + "Would you like to continue?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)No");
        }
        public void DisplayerPressCToContinue()
        {
            Console.WriteLine("Press C to continue to next step");
        }
        public void DisplayCostOfProduct()
        {
            Console.WriteLine("The current cost for each one of your products is " + player.recipeBook.cost + "$.");
        }
        public void DisplayPlayerRecipe()
        {
            Console.WriteLine(Environment.NewLine + "" + player.name + "'s recipe consists of: " + Environment.NewLine + +player.recipeBook.item1RecipeAmount + " " + player.inventory.item1name + "(s), " + Environment.NewLine + +player.recipeBook.item2RecipeAmount + " " + player.inventory.item2name + "(s), " + Environment.NewLine + +player.recipeBook.item3RecipeAmount + " " + player.inventory.item3name + "(s), " + Environment.NewLine + +player.recipeBook.item4RecipeAmount + " " + player.inventory.item4name + "(s). ");
        }
        public void DisplayItem1RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + player.inventory.item1name + " out of " + player.inventory.item1Amount + " would you like to use? (0-" + player.inventory.item1Amount + ")");
        }
        public void DisplayItem2RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + player.inventory.item2name + " out of " + player.inventory.item2Amount + " would you like to use? (0-" + player.inventory.item2Amount + ")");
        }
        public void DisplayItem3RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + player.inventory.item3name + " out of " + player.inventory.item3Amount + " would you like to use? (0-" + player.inventory.item3Amount + ")");
        }
        public void DisplayItem4RecipeOption()
        {
            Console.WriteLine(Environment.NewLine + "How many " + player.inventory.item4name + " out of " + player.inventory.item4Amount + " would you like to use? (0-" + player.inventory.item4Amount + ")");
        }
        public void DisplayCostOptions()
        {
            Console.WriteLine(Environment.NewLine + " How much would you like to charge for each one of your products? (0$ - 100$)");
        }
        public void DisplayRoundStart()
        {
            Console.WriteLine(Environment.NewLine + "Your recipe consists of: " + Environment.NewLine + +player.recipeBook.item1RecipeAmount + " " + player.inventory.item1name + "(s)." + Environment.NewLine + +player.recipeBook.item2RecipeAmount + " " + player.inventory.item2name + "(s)." + Environment.NewLine + +player.recipeBook.item3RecipeAmount + " " + player.inventory.item3name + "(s).");
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
        public void DisplayEndDateOption()
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
        public void DisplayContinueOption()
        {
            Console.WriteLine(Environment.NewLine + "Would you like to continue to the next step?" + Environment.NewLine + "1)Yes" + Environment.NewLine + "2)Not Yet");
        }
        public void NotifyLackOfItem1()
        {
            Console.WriteLine("You do not have enough of " + player.inventory.item1name + " to add that to your recipe.");
        }
        public void NotifyLackOfItem2()
        {
            Console.WriteLine("You do not have enough of " + player.inventory.item2name + " to add that to your recipe.");
        }
        public void NotifyLackOfItem3()
        {
            Console.WriteLine("You do not have enough of " + player.inventory.item3name + " to add that to your recipe.");
        }
        public void NotifyLackOfItem4()
        {
            Console.WriteLine("You do not have enough of " + player.inventory.item4name + " to add that to your recipe.");
        }
    }
}
