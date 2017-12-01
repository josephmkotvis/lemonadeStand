using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {  // member 
        Random rnd = new Random();
        public Player player;
        public UserInterface UI;
        public Store store;
        public Day day1;
        public Day day2;
        public Day day3;
        public Day day4;
        public Day day5;
        public Day day6;
        public Day day7;
        BussinessPerson customer1;
        Banker customer2;
        Millionare customer3;
        Student customer4;
        Teacher customer5;
        Athlete customer6;
        ConstructionWorker customer7;
        public Weather weather;
        public Customer customer;
        private double startingCustomers = 30;
        private double amountOfVisitors;
        private bool endCondition = false;
        //constructor
        public Game()
        {
            Cup item1 = new Cup();
            Lemon item2 = new Lemon();
            Sugar item3 = new Sugar();
            Ice item4 = new Ice();
            this.day1 = new Day();
            this.day2 = new Day();
            this.day3 = new Day();
            this.day4 = new Day();
            this.day5 = new Day();
            this.day6 = new Day();
            this.day7 = new Day();
            this.store = new Store(item1, item2, item3, item4);
            this.player = new Player("Player1", store, item1, item2, item3, item4);     
            this.weather = new Weather();
            this.customer = new Customer(player, weather, "Customer", "None", 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0);
            this.customer1 = new BussinessPerson(player, weather, "BussinessPerson", "Sunny", 65, 10, 10, 3, 1, 9, 6, 3, 0, 12, 14, 26);
            this.customer2 = new Banker(player, weather, "Banker", "Rain", 80, 30, 10, 1, 2, 5, 1, 0, 8, 10, 4, 16);
            this.customer3 = new Millionare(player, weather, "Millionare", "None", 100, 30, 12, 500, 500, 500 ,500, 0, 0, 0, 0, 0);
            this.customer4 = new Student(player, weather, "Student", "Hail", 34, 12, 5, 1, 15, 20, 3, 0, 8, 13, 12, 1);
            this.customer5 = new Teacher(player, weather, "Teacher", "Foggy", 45, 12, 14, 1, 6, 4, 3, 0, 1, 1, 1, 10);
            this.customer6 = new Athlete(player, weather, "Athlete", "Snow", 10, 18, 2, 1, 4, 0, 25, 0, 2, 3, 0, 10);
            this.customer7 = new ConstructionWorker(player, weather, "Construction Worker", "Windy", 90, 35, 0, 1, 13, 10, 14, 0, 4, 8, 0, 7);
            this.UI = new UserInterface(player, store, day1, day2, day3, day4, day5, day6, day7, customer1, customer2, customer3, customer4, customer5, customer6, customer7);
        }


        //methods

        public void RunGame()
        {
            UI.DisplayFaq();
            AskToChooseEndDate();
            AskToChoosePlayerName();
            SetStartingWeather();
            do
            {
                RunRound();
                CheckEndingConditon();
            } while (endCondition == false);
            UI.DisplayEndDateOption();
        }
        void RunRound()
        {
            RunPreSellingPart();
            RunSellingPart();
            RunPostSellingPart();
            ResetStats();

        }
        void RunPostSellingPart()
        {
            UI.DisplayMoneyChanges();
            UI.DisplayCustomerReviews();
            ResetMoneyGainedThisRound();
            TransferDayWeathers();
            UpdatCurrentDay();
            CheckEndingConditon();
        }
        void ResetStats()
        {
            ResetMoneyGainedThisRound();
            ResetComplaints();
            ResetCompliments();
            ResetAttendance();
            ResetRecipe();
            ResetSales();
        }
        void ResetSales()
        {
            player.inventory.item1Sold = 0;
            player.inventory.item2Sold = 0;
            player.inventory.item3Sold = 0;
            player.inventory.item4Sold = 0;
            player.inventory.merchandiseSold= 0;

        }
        void ResetRecipe()
        {
            player.recipeBook.item1RecipeAmount = 0;
            player.recipeBook.item2RecipeAmount = 0;
            player.recipeBook.item3RecipeAmount = 0;
            player.recipeBook.item4RecipeAmount = 0;
            player.recipeBook.cost = 0;
        }
        void ResetAttendance()
        {
            player.attendanceList.amountOfAllCustomersToAttend = 0;
        }
        void ResetCompliments()
        {
            player.reviewBook.complimentsAboutObject1 = 0;
            player.reviewBook.complimentsAboutObject2 = 0;
            player.reviewBook.complimentsAboutObject3 = 0;
            player.reviewBook.complimentsAboutObject4 = 0;
        }
        void ResetComplaints()
        {
            player.reviewBook.complaintsAboutObject1 = 0;
            player.reviewBook.complaintsAboutObject2 = 0;
            player.reviewBook.complaintsAboutObject3 = 0;
            player.reviewBook.complaintsAboutObject4 = 0;
            player.reviewBook.complaintsAboutFlavor = 0;
            player.reviewBook.complaintsAboutNoDrinks = 0;
            player.reviewBook.complaintsAboutWeather = 0;
        }
        void RunSellingPart()
        {
            for (int i = 0; i < amountOfVisitors; i++)
            {
                    ChooseRandomBuyer();
            }
            UI.ClearConsoleLog();
            UI.DisplaySalesResults();
            player.SetPlayerInput();
        }
        void SavePreRoundMoney()
        {
            player.piggyBank.preGameMoney=player.piggyBank.money;
        }
        void ResetMoneyGainedThisRound()
        {
            player.piggyBank.gainedMoney = 0;
        }
        void ChooseRandomBuyer()
        {
            int choosenBuyer = rnd.Next(1, 8);
            switch (choosenBuyer)
            {
                case 1:
                    customer1.DecideToGo();
                    break;
                case 2:
                    customer2.DecideToGo();
                    break;
                case 3:
                    customer3.DecideToGo();
                    break;
                case 4:
                    customer4.DecideToGo();
                    break;
                case 5:
                    customer5.DecideToGo();
                    break;
                case 6:
                    customer6.DecideToGo();
                    break;
                case 7:
                    customer7.DecideToGo();
                    break;
            }
        }
        void SetAmountOfVisitors()
        {
            amountOfVisitors = startingCustomers + ((player.attendanceList.percentageOfCustomersAttended + 1) * startingCustomers);
        }
        void RunPreSellingPart()
        {
            SavePreRoundMoney();
            TransferDayWeathers();
            UI.ClearConsoleLog();
            AskToChooseBuyingOptions();
            PromptToChooseRecipe();
            AskToChooseProductPrice();
            SetAmountOfVisitors();
        }
        void SetStartingWeather()
        {
            SetDay1Weather();
            SetDay2Weather();
            SetDay3Weather();
            SetDay4Weather();
            SetDay5Weather();
            SetDay6Weather();
            SetDay7Weather();

        }
        void TransferDayWeathers()
        {
            TransferDay2WeatherToDay1();
            TransferDay3WeatherToDay2();
            TransferDay4WeatherToDay3();
            TransferDay5WeatherToDay4();
            TransferDay6WeatherToDay5();
            TransferDay7WeatherToDay6();
            SetDay7Weather();

        }
        void TransferDay2WeatherToDay1()
        {
            day1.currentWeatherType = day2.currentWeatherType;
            day1.currentAirTemperature = day2.currentAirTemperature;
            day1.currentHumidity = day2.currentHumidity;
            day1.currentWindSpeed = day2.currentWindSpeed;
            day1.currentPrecipitation = day2.currentPrecipitation;
        }
        void TransferDay3WeatherToDay2()
        {
            day2.currentWeatherType = day3.currentWeatherType;
            day2.currentAirTemperature = day3.currentAirTemperature;
            day2.currentHumidity = day3.currentHumidity;
            day2.currentWindSpeed = day3.currentWindSpeed;
            day2.currentPrecipitation = day3.currentPrecipitation;
        }
        void TransferDay4WeatherToDay3()
        {
            day3.currentWeatherType = day4.currentWeatherType;
            day3.currentAirTemperature = day4.currentAirTemperature;
            day3.currentHumidity = day4.currentHumidity;
            day3.currentWindSpeed = day4.currentWindSpeed;
            day3.currentPrecipitation = day4.currentPrecipitation;
        }
        void TransferDay5WeatherToDay4()
        {
            day4.currentWeatherType = day5.currentWeatherType;
            day4.currentAirTemperature = day5.currentAirTemperature;
            day4.currentHumidity = day5.currentHumidity;
            day4.currentWindSpeed = day5.currentWindSpeed;
            day4.currentPrecipitation = day5.currentPrecipitation;
        }
        void TransferDay6WeatherToDay5()
        {
            day5.currentWeatherType = day6.currentWeatherType;
            day5.currentAirTemperature = day6.currentAirTemperature;
            day5.currentHumidity = day6.currentHumidity;
            day5.currentWindSpeed = day6.currentWindSpeed;
            day5.currentPrecipitation = day6.currentPrecipitation;
        }
        void TransferDay7WeatherToDay6()
        {
            day6.currentWeatherType = day7.currentWeatherType;
            day6.currentAirTemperature = day7.currentAirTemperature;
            day6.currentHumidity = day7.currentHumidity;
            day6.currentWindSpeed = day7.currentWindSpeed;
            day6.currentPrecipitation = day7.currentPrecipitation;
        }
        void SetDay1Weather()
        {
            GetWeatherVariables();
            SetDay1WeatherVariables();
        }
        void SetDay2Weather()
        {
            GetWeatherVariables();
            SetDay2WeatherVariables();
        }
        void SetDay3Weather()
        {
            GetWeatherVariables();
            SetDay3WeatherVariables();
        }
        void SetDay4Weather()
        {
            GetWeatherVariables();
            SetDay4WeatherVariables();
        }
        void SetDay5Weather()
        {
            GetWeatherVariables();
            SetDay5WeatherVariables();
        }
        void SetDay6Weather()
        {
            GetWeatherVariables();
            SetDay6WeatherVariables();
        }
        void SetDay7Weather()
        {
            GetWeatherVariables();
            SetDay7WeatherVariables();
        }
        void SetDay2WeatherVariables()
        {
            day2.currentWeatherType = weather.weatherType;
            day2.currentAirTemperature = weather.airTemperature;
            day2.currentHumidity = weather.humidity;
            day2.currentWindSpeed = weather.windSpeed;
            day2.currentPrecipitation = weather.precipitation;
        }
        void SetDay3WeatherVariables()
        {
            day3.currentWeatherType = weather.weatherType;
            day3.currentAirTemperature = weather.airTemperature;
            day3.currentHumidity = weather.humidity;
            day3.currentWindSpeed = weather.windSpeed;
            day3.currentPrecipitation = weather.precipitation;
        }
        void SetDay4WeatherVariables()
        {
            day4.currentWeatherType = weather.weatherType;
            day4.currentAirTemperature = weather.airTemperature;
            day4.currentHumidity = weather.humidity;
            day4.currentWindSpeed = weather.windSpeed;
            day4.currentPrecipitation = weather.precipitation;
        }
        void SetDay5WeatherVariables()
        {
            day5.currentWeatherType = weather.weatherType;
            day5.currentAirTemperature = weather.airTemperature;
            day5.currentHumidity = weather.humidity;
            day5.currentWindSpeed = weather.windSpeed;
            day5.currentPrecipitation = weather.precipitation;
        }
        void SetDay6WeatherVariables()
        {
            day6.currentWeatherType = weather.weatherType;
            day6.currentAirTemperature = weather.airTemperature;
            day6.currentHumidity = weather.humidity;
            day6.currentWindSpeed = weather.windSpeed;
            day6.currentPrecipitation = weather.precipitation;
        }
        void SetDay7WeatherVariables()
        {
            day7.currentWeatherType = weather.weatherType;
            day7.currentAirTemperature = weather.airTemperature;
            day7.currentHumidity = weather.humidity;
            day7.currentWindSpeed = weather.windSpeed;
            day7.currentPrecipitation = weather.precipitation;
        }
        void GetWeatherVariables()
        {
            weather.weatherTypeNumber = rnd.Next(1, 6);
            switch (weather.weatherTypeNumber)
            {
                case 1:
                    MatchWeatherNumberToSunny();
                    break;
                case 2:
                    MatchWeatherNumberToRain();
                    break;
                case 3:
                    MatchWeatherNumberToHail();
                    break;
                case 4:
                    MatchWeatherNumberToFoggy();
                    break;
                case 5:
                    MatchWeatherNumberToWindy();
                    break;
            }
           
        }
        void SetDay1WeatherVariables()
        {
            day1.currentWeatherType = weather.weatherType;
            day1.currentAirTemperature = weather.airTemperature;
            day1.currentHumidity = weather.humidity;
            day1.currentWindSpeed = weather.windSpeed;
            day1.currentPrecipitation = weather.precipitation;

        }
        void MatchWeatherNumberToSunny()
        {
            weather.weatherType = "Sunny";
            weather.airTemperature = rnd.Next(70, 91);
            weather.humidity = rnd.Next(40, 90);
            weather.windSpeed = rnd.Next(0, 20);
            weather.precipitation = rnd.Next(0, 10);
        }
        void MatchWeatherNumberToRain()
        {
            weather.weatherType = "Rain";
            weather.airTemperature = rnd.Next(32, 80);
            weather.humidity = rnd.Next(60, 80);
            weather.windSpeed = rnd.Next(0, 20);
            weather.precipitation = rnd.Next(0, 10);
        }
        void MatchWeatherNumberToHail()
        {
            weather.weatherType = "Hail";
            weather.airTemperature = rnd.Next(40, 60);
            weather.humidity = rnd.Next(40, 60);
            weather.windSpeed = rnd.Next(0, 20);
            weather.precipitation = rnd.Next(0, 10);
        }
        void MatchWeatherNumberToFoggy()
        {
            weather.weatherType = "Foggy";
            weather.airTemperature = rnd.Next(30, 51);
            weather.humidity = rnd.Next(80, 90);
            weather.windSpeed = rnd.Next(0, 10);
            weather.precipitation = rnd.Next(8, 10);
        }
        void MatchWeatherNumberToWindy()
        {
            weather.weatherType = "Windy";
            weather.airTemperature = rnd.Next(30, 90);
            weather.humidity = rnd.Next(30, 70);
            weather.windSpeed = rnd.Next(0, 10);
            weather.precipitation = rnd.Next(0, 10);
        }
        void AskToChooseProductPrice()
        {
            do
            {
                UI.DisplayCostOptions();
                player.SetPlayerInput();
                CheckPlayerInputForCost();
                player.recipeBook.cost = (Convert.ToDouble(player.input));
                UI.DisplayCostOfProduct();
                CheckIfReady();
            } while (player.desireToContinue == false);
            ResetPlayerDesireToConinue();
            }
        void CheckPlayerInputForCost()
        {
            if ((player.input == "") || (Convert.ToDouble(player.input) > 100) || (Convert.ToDouble(player.input) < 0))
            {
                UI.DisplayIncorrectOption();
            }
        }
        void AskToChooseRecipe()
        {
            UI.ClearConsoleLog();
            UI.DisplayContinuationToRecipe();
            player.SetPlayerInput();
            switch (player.input)
            {
                case "1":
                    PromptToChooseRecipe();
                    break;
                case "2":
                    UI.DisplayIncorrectChoice();
                    UI.DisplayPressToContinue();
                    player.SetPlayerInput();
                    break;
            }
        }
        void PromptToChooseRecipe()
        {
            do
            {
                AskToChangeItem1Recipe();
                AskToChangeItem2Recipe();
                AskToChangeItem3Recipe();
                AskToChangeItem4Recipe();
                UI.ClearConsoleLog();
                UI.DisplayPlayerRecipe();
                CheckIfReady();
            } while (player.desireToContinue == false);
            ResetPlayerDesireToConinue();
        }
        void ResetPlayerDesireToConinue()
        {
            player.desireToContinue = false;
        }
        void AskToChangeItem1Recipe()
        {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayPlayerRecipe();
                UI.DisplayItem1RecipeOption();
                player.SetPlayerInput();
                SetPlayerRecipeChangeNumber();
                CheckItem1ForRecipe();
        }
        void AskToChangeItem2Recipe()
        {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayPlayerRecipe();
                UI.DisplayItem2RecipeOption();
                player.SetPlayerInput();
                SetPlayerRecipeChangeNumber();
                CheckItem2ForRecipe();
        }
        void AskToChangeItem3Recipe()
        {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayPlayerRecipe();
                UI.DisplayItem3RecipeOption();
                player.SetPlayerInput();
                SetPlayerRecipeChangeNumber();
                CheckItem3ForRecipe();
        }
        void AskToChangeItem4Recipe()
        {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayPlayerRecipe();
                UI.DisplayItem4RecipeOption();
                player.SetPlayerInput();
                SetPlayerRecipeChangeNumber();
                CheckItem4ForRecipe();
        }
        void SetPlayerRecipeChangeNumber()
        {
            if (player.input == "")
            {
                player.recipeBook.playerRecipeChangeNumber = 0;
            }
            else
            {
                player.recipeBook.playerRecipeChangeNumber = Convert.ToDouble(player.input);
            }
        }
        void AskToChoosePlayerName()
        {
            UI.DisplayPlayerNameOption();
            player.SetPlayerInput();
            player.name = player.input;
        }
        public void AskToChooseEndDate()
        {
            UI.DisplayEndDateOption();
            player.SetPlayerInput();
            player.chosenEndDate = Convert.ToInt32(player.input);
            CheckEndDateChoie();
        }
        void CheckEndDateChoie()
        {
            if ((player.chosenEndDate > 50) || (player.chosenEndDate <1))
            {
                UI.DisplayIncorrectChoice();
                AskToChooseEndDate();
            }
        }
        void CheckItem1ForRecipe()
        {
            if (player.inventory.item1Amount < player.recipeBook.playerRecipeChangeNumber)
            {
                UI.NotifyLackOfItem1();
                player.SetPlayerInput();
            }
            else if (player.inventory.item1Amount >= player.recipeBook.playerRecipeChangeNumber)
            {
                player.ChangeItem1Recipe();
            }
        }
        void CheckItem2ForRecipe()
        {
            if (player.inventory.item2Amount < player.recipeBook.playerRecipeChangeNumber)
            {
                UI.NotifyLackOfItem2();
                player.SetPlayerInput();
            }
            else if (player.inventory.item2Amount >= player.recipeBook.playerRecipeChangeNumber)
            {
                player.ChangeItem2Recipe();
            }
        }
        void CheckItem3ForRecipe()
        {
            if (player.inventory.item3Amount < player.recipeBook.playerRecipeChangeNumber)
            {
                UI.NotifyLackOfItem3();
                player.SetPlayerInput();
            }
            else if (player.inventory.item3Amount >= player.recipeBook.playerRecipeChangeNumber)
            {
                player.ChangeItem3Recipe();
            }
        }
        void CheckItem4ForRecipe()
        {
            if (player.inventory.item4Amount < player.recipeBook.playerRecipeChangeNumber)
            {
                UI.NotifyLackOfItem4();
                player.SetPlayerInput();
            }
            else if (player.inventory.item4Amount >= player.recipeBook.playerRecipeChangeNumber)
            {
                player.ChangeItem4Recipe();
            }
        }
        void CheckIfReady()
        {
            UI.DisplayContinueOption();
            player.SetPlayerInput();
            switch (player.input)
            {
                case "1":
                    player.desireToContinue = true;
                    break;
                case "2":
                    player.desireToContinue = false;
                    break;
            }
        }
        public void AskToChooseBuyingOptions()
        {
            do
            {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayStoreOptions();
                player.SetPlayerInput();
                switch (player.input)
                {
                    case "1":
                        CheckMoneyForItem1();
                        break;
                    case "2":
                        CheckMoneyForItem2();
                        break;
                    case "3":
                        CheckMoneyForItem3();
                        break;
                    case "4":
                        CheckMoneyForItem4();
                        break;
                    case "5":
                        AskToChooseItemBundleSelection();
                        break;
                    case "6":
                        CheckIfStillBuying();
                        break;
                    default:
                        UI.DisplayIncorrectOption();
                        player.SetPlayerInput();
                        break;
                }
            } while (player.desireToContinue == false);
            ResetPlayerDesireToConinue();
        }
        void AskToChooseItemBundleSelection()
        {
            do
            {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayItemBundles();
                player.SetPlayerInput();
                switch (player.input)
                {
                    case "1":
                        AskToChooseItem1Bundle();
                        break;
                    case "2":
                        AskToChooseItem2Bundle();
                        break;
                    case "3":
                        AskToChooseItem3Bundle();
                        break;
                    case "4":
                        AskToChooseItem4Bundle();
                        break;
                    case "5":
                        AskToChooseBuyingOptions();
                        break;
                    case "6":
                        UI.ClearConsoleLog();
                        CheckIfReady();
                        break;
                    default:
                        UI.DisplayIncorrectOption();
                        player.SetPlayerInput();
                        break;
                }
            } while (player.desireToContinue == false);
        }
        void AskToChooseItem1Bundle()
        {
            do
            {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayItem1Bundles();
                player.SetPlayerInput();
                switch (player.input)
                {
                    case "1":
                        CheckMoneyForItem1Bundle1();
                        break;
                    case "2":
                        CheckMoneyForItem1Bundle2();
                        break;
                    case "3":
                        CheckMoneyForItem1Bundle3();
                        break;
                    case "4":
                        AskToChooseItemBundleSelection();
                        break;
                    case "5":
                        UI.ClearConsoleLog();
                        CheckIfReady();
                        break;
                    default:
                        UI.DisplayIncorrectOption();
                        player.SetPlayerInput();
                        break;
                }
            } while (player.desireToContinue == false);
        }
        void AskToChooseItem2Bundle()
        {
            do
            {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayItem2Bundles();
                player.SetPlayerInput();
                switch (player.input)
                {
                    case "1":
                        CheckMoneyForItem2Bundle1();
                        break;
                    case "2":
                        CheckMoneyForItem2Bundle2();
                        break;
                    case "3":
                        CheckMoneyForItem2Bundle3();
                        break;
                    case "4":
                        AskToChooseItemBundleSelection();
                        break;
                    case "5":
                        UI.ClearConsoleLog();
                        CheckIfReady();
                        break;
                    default:
                        UI.DisplayIncorrectOption();
                        player.SetPlayerInput();
                        break;
                }
            } while (player.desireToContinue == false);
        }
        void AskToChooseItem3Bundle()
        {
            do
            {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayItem3Bundles();
                player.SetPlayerInput();
                switch (player.input)
                {
                    case "1":
                        CheckMoneyForItem3Bundle1();
                        break;
                    case "2":
                        CheckMoneyForItem3Bundle2();
                        break;
                    case "3":
                        CheckMoneyForItem3Bundle3();
                        break;
                    case "4":
                        AskToChooseItemBundleSelection();
                        break;
                    case "5":
                        UI.ClearConsoleLog();
                        CheckIfReady();
                        break;
                    default:
                        UI.DisplayIncorrectOption();
                        player.SetPlayerInput();
                        break;
                }
            } while (player.desireToContinue == false);
        }
        void AskToChooseItem4Bundle()
        {
            do
            {
                UI.ClearConsoleLog();
                UI.DisplayRoundInfo();
                UI.DisplayItem4Bundles();
                player.SetPlayerInput();
                switch (player.input)
                {
                    case "1":
                        CheckMoneyForItem4Bundle1();
                        break;
                    case "2":
                        CheckMoneyForItem4Bundle2();
                        break;
                    case "3":
                        CheckMoneyForItem4Bundle3();
                        break;
                    case "4":
                        AskToChooseItemBundleSelection();
                        break;
                    case "5":
                        UI.ClearConsoleLog();
                        CheckIfReady();
                        break;
                    default:
                        UI.DisplayIncorrectOption();
                        player.SetPlayerInput();
                        break;
                }
            } while (player.desireToContinue == false);
        }
        void CheckMoneyForItem1Bundle1()
        {
            if (player.piggyBank.money < store.item1Bundle1Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item1Bundle1Cost)
            {
                player.BuyItem1Bundle1();
            }
        }
        void CheckMoneyForItem1Bundle2()
        {
            if (player.piggyBank.money < store.item1Bundle2Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item1Bundle2Cost)
            {
                player.BuyItem1Bundle2();
            }
        }
        void CheckMoneyForItem1Bundle3()
        {
            if (player.piggyBank.money < store.item1Bundle3Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item1Bundle3Cost)
            {
                player.BuyItem1Bundle3();
            }
        }
        void CheckMoneyForItem2Bundle1()
        {
            if (player.piggyBank.money < store.item2Bundle1Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item2Bundle1Cost)
            {
                player.BuyItem2Bundle1();
            }
        }
        void CheckMoneyForItem2Bundle2()
        {
            if (player.piggyBank.money < store.item2Bundle2Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item2Bundle2Cost)
            {
                player.BuyItem2Bundle2();
            }
        }
        void CheckMoneyForItem2Bundle3()
        {
            if (player.piggyBank.money < store.item2Bundle3Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item2Bundle3Cost)
            {
                player.BuyItem2Bundle3();
            }
        }
        void CheckMoneyForItem3Bundle1()
        {
            if (player.piggyBank.money < store.item3Bundle1Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item3Bundle1Cost)
            {
                player.BuyItem3Bundle1();
            }
        }
        void CheckMoneyForItem3Bundle2()
        {
            if (player.piggyBank.money < store.item3Bundle2Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item3Bundle2Cost)
            {
                player.BuyItem3Bundle2();
            }
        }
        void CheckMoneyForItem3Bundle3()
        {
            if (player.piggyBank.money < store.item3Bundle3Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item3Bundle3Cost)
            {
                player.BuyItem3Bundle3();
            }
        }
        void CheckMoneyForItem4Bundle1()
        {
            if (player.piggyBank.money < store.item4Bundle1Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item4Bundle1Cost)
            {
                player.BuyItem4Bundle1();
            }
        }
        void CheckMoneyForItem4Bundle2()
        {
            if (player.piggyBank.money < store.item4Bundle2Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item4Bundle2Cost)
            {
                player.BuyItem4Bundle2();
            }
        }
        void CheckMoneyForItem4Bundle3()
        {
            if (player.piggyBank.money < store.item4Bundle3Cost)
            {
                UI.NotifyLackOfMoney();
                player.SetPlayerInput();
            }
            else if (player.piggyBank.money >= store.item4Bundle3Cost)
            {
                player.BuyItem4Bundle3();
            }
        }
        void CheckIfStillBuying()
        {
            UI.ClearConsoleLog();
            UI.DisplayPlayer1Inventory();
            UI.DisplayFinishBuyingOption();
            player.SetPlayerInput();
            switch (player.input)
            {
                case "1":
                    player.desireToContinue = true;
                    break;
                case "2":
                    player.desireToContinue = false;
                    break;
                default:
                    UI.DisplayIncorrectChoice();
                    CheckIfStillBuying();
                    break;
            }
        }
        void CheckMoneyForItem1()
        {
            if (player.piggyBank.money < store.item1Cost)
            {
                UI.NotifyLackOfMoney();

            }
            else if (player.piggyBank.money >= store.item1Cost)
            {
                player.BuyItem1();
            }
        }
        void CheckMoneyForItem2()
        {
            if (player.piggyBank.money < store.item2Cost)
            {
                UI.NotifyLackOfMoney();
            }
            else if (player.piggyBank.money >= store.item2Cost)
            {
                player.BuyItem2();
            }
        }
        void CheckMoneyForItem3()
        {
            if (player.piggyBank.money < store.item3Cost)
            {
                UI.NotifyLackOfMoney();
            }
            else if (player.piggyBank.money >= store.item3Cost)
            {
                player.BuyItem3();
            }
        }
        void CheckMoneyForItem4()
        {
            if (player.piggyBank.money < store.item4Cost)
            {
                UI.NotifyLackOfMoney();
            }
            else if (player.piggyBank.money >= store.item4Cost)
            {
                player.BuyItem4();
            }
        }
        void CheckEndingConditon()
        {
            if (day1.currentDay == player.chosenEndDate)
            {
                endCondition = true;
            }
        }
        void UpdatCurrentDay()
        {
            day1.currentDay++;
        }
        void SaveGame()
        {
            //save game with sql
        }
    }
}
