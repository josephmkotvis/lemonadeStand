using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {  // member 
        public Player player;
        public UserInterface UI;
        public Store store;
        public Day day;
        private bool endCondition = false;
        public Weather weather;
        public Customer customer;
        public ComplaintBook complaintBook;
        AttendanceList attendanceList;


        //constructor
        public Game()
        {
            Lemon item1 = new Lemon();
            Sugar item2 = new Sugar();
            Ice item3 = new Ice();
            Cup item4 = new Cup();
            this.day = new Day();
            this.store = new Store(item1, item2, item3, item4);
            this.player = new Player("Player1", store, item1, item2, item3, item4);
            this.weather = new Weather();
            this.complaintBook = new ComplaintBook();
            this.attendanceList = new AttendanceList();
            this.customer = new Customer(player, weather, complaintBook, attendanceList);
            this.UI = new UserInterface(player, store, day);
        }


        //methods

        public void RunGame()
        {
            UI.DisplayFaq();
            AskToChooseEndDate();
            // ask game type 2 player or 1 player if add later
            AskToChoosePlayerName();
            do
            {
                RunRound();
            } while (endCondition == false);
        }
        void RunRound()
        {
            UI.ClearConsoleLog();
            AskToChooseBuyingOptions();
            PromptToChooseRecipe();
            // runs the lemonade stand days
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
            // when it hits game.days (Amount of days they chose)
        }
        void UpdatCurrentDay()
        {
            day.currentDay++;
        }
    }
}
