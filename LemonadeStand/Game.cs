using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {  // member variables

        UserInterface UI;
        Player player1;
        Day day;
        Inventory inventory1;
        Store store;
        private bool endCondition = false;


        //constructor
        public Game(UserInterface UI,Player player1,Day day,Inventory inventory1, Store store)
        {
            this.UI = UI;
            this.player1 = player1;
            this.day = day;
            this.inventory1 = inventory1;
            this.store = store;

        }

        //methods

        public void RunGame()
        {
            UI.DisplayFaq();
            // ask game type 2 player or 1 player if add later
            SetPlayer1Name();
            SetEndDate();
            do
            {
                RunRound();
            } while (endCondition == false);
        }
        void RunRound()
        {
            ClearConsoleLog();
            ChooseBuyingOptions();
            //recipe
            CheckIfReadyToContinueToSelling();



            // runs the lemonade stand days
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
        void DisplayRoundInfo()
        {
            ClearConsoleLog();
            UI.DisplayDay();
            UI.DisplayWeatherToday();
            UI.DisplayPlayer1Money();
            UI.DisplayPlayer1Inventory();
        }
        void ClearConsoleLog()
        {
            Console.Clear();
        }
        void CheckEndDateChoie()
        {
            if (player1.chosenEndDate > 50)
            {
                UI.DisplayIncorrectChoice();
                SetEndDate();
            }
        }
        void DisplayIncorrectOption()
        {
            ClearConsoleLog();
            UI.DisplayIncorrectChoice();
            UI.DisplayPressToContinue();
            UI.GetUserInput();
        }
        void ChooseBuyingOptions()
        {
            ClearConsoleLog();
            DisplayRoundInfo();
            UI.DisplayStoreOptions();
            UI.GetUserInput();
            switch (UI.userInput)
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
                    ChooseItemBundleSelection();
                    break;
                case "6":
                    ChooseToKeepBuying();
                    break;
                default:
                    DisplayIncorrectOption();
                    break;
            }
            ChooseBuyingOptions();

        }
        void ChooseItemBundleSelection()
        {
            ClearConsoleLog();
            DisplayRoundInfo();
            UI.DisplayItemBundles();
            UI.GetUserInput();
            switch (UI.userInput)
            {
                case "1":
                    ChooseItem1Bundle();
                    break;
                case "2":
                    ChooseItem2Bundle();
                    break;
                case "3":
                    ChooseItem3Bundle();
                    break;
                case "4":
                    ChooseItem4Bundle();
                    break;
                case "5":
                    ChooseBuyingOptions();
                    break;
                case "6":
                    ClearConsoleLog();
                    UI.DisplayPlayer1Inventory();
                    UI.DisplayPressToContinue();
                    break;
                default:
                    DisplayIncorrectOption();
                    break;
            }
            ChooseItemBundleSelection();

        }
        void ChooseItem1Bundle()
        {
            ClearConsoleLog();
            DisplayRoundInfo();
            UI.DisplayItem1Bundles();
            UI.GetUserInput();
            switch (UI.userInput)
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
                    ChooseItemBundleSelection();
                    break;
                case "5":
                    ClearConsoleLog();
                    UI.DisplayPlayer1Inventory();
                    UI.DisplayPressToContinue();
                    break;
                default:
                    DisplayIncorrectOption();
                    break;
            }
            ChooseItem1Bundle();
        }
        void ChooseItem2Bundle()
        {
            ClearConsoleLog();
            DisplayRoundInfo();
            UI.DisplayItem2Bundles();
            UI.GetUserInput();
            switch (UI.userInput)
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
                    ChooseItemBundleSelection();
                    break;
                case "5":
                    ClearConsoleLog();
                    UI.DisplayPlayer1Inventory();
                    UI.DisplayPressToContinue();
                    break;
                default:
                    DisplayIncorrectOption();
                    break;
            }
            ChooseItem2Bundle();
        }
        void ChooseItem3Bundle()
        {
            ClearConsoleLog();
            DisplayRoundInfo();
            UI.DisplayItem3Bundles();
            UI.GetUserInput();
            switch (UI.userInput)
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
                    ChooseItemBundleSelection();
                    break;
                case "5":
                    ClearConsoleLog();
                    UI.DisplayPlayer1Inventory();
                    UI.DisplayPressToContinue();
                    break;
                default:
                    DisplayIncorrectOption();
                    break;
            }
            ChooseItem3Bundle();
        }
        void ChooseItem4Bundle()
        {
            ClearConsoleLog();
            DisplayRoundInfo();
            UI.DisplayItem4Bundles();
            UI.GetUserInput();
            switch (UI.userInput)
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
                    ChooseItemBundleSelection();
                    break;
                case "5":
                    ClearConsoleLog();
                    UI.DisplayPlayer1Inventory();
                    UI.DisplayPressToContinue();
                    break;
                default:
                    DisplayIncorrectOption();
                    break;
            }
            ChooseItem4Bundle();
        }
        void BuyItem1Bundle1()
        {
            player1.money -= store.item1Bundle1Cost;
            inventory1.item1Amount += store.bundle1Amount;
        }
        void CheckMoneyForItem1Bundle1()
        {
            if (player1.money < store.item1Bundle1Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item1Bundle1Cost)
            {
                BuyItem1Bundle1();
            }
        }
        void BuyItem1Bundle2()
        {
            player1.money -= store.item1Bundle2Cost;
            inventory1.item1Amount += store.bundle2Amount;
        }
        void CheckMoneyForItem1Bundle2()
        {
            if (player1.money < store.item1Bundle2Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item1Bundle2Cost)
            {
                BuyItem1Bundle2();
            }
        }
        void BuyItem1Bundle3()
        {
            player1.money -= store.item1Bundle3Cost;
            inventory1.item1Amount += store.bundle3Amount;
        }
        void CheckMoneyForItem1Bundle3()
        {
            if (player1.money < store.item1Bundle3Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item1Bundle3Cost)
            {
                BuyItem1Bundle3();
            }
        }
        void BuyItem2Bundle1()
        {
            player1.money -= store.item2Bundle1Cost;
            inventory1.item2Amount += store.bundle1Amount;
        }
        void CheckMoneyForItem2Bundle1()
        {
            if (player1.money < store.item2Bundle1Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item2Bundle1Cost)
            {
                BuyItem2Bundle1();
            }
        }
        void BuyItem2Bundle2()
        {
            player1.money -= store.item2Bundle2Cost;
            inventory1.item2Amount += store.bundle2Amount;
        }
        void CheckMoneyForItem2Bundle2()
        {
            if (player1.money < store.item2Bundle2Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item2Bundle2Cost)
            {
                BuyItem2Bundle2();
            }
        }
        void BuyItem2Bundle3()
        {
            player1.money -= store.item1Bundle3Cost;
            inventory1.item2Amount += store.bundle3Amount;
        }
        void CheckMoneyForItem2Bundle3()
        {
            if (player1.money < store.item2Bundle3Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item2Bundle3Cost)
            {
                BuyItem2Bundle3();
            }
        }
        void BuyItem3Bundle1()
        {
            player1.money -= store.item3Bundle1Cost;
            inventory1.item3Amount += store.bundle1Amount;
        }
        void CheckMoneyForItem3Bundle1()
        {
            if (player1.money < store.item3Bundle1Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item3Bundle1Cost)
            {
                BuyItem3Bundle1();
            }
        }
        void BuyItem3Bundle2()
        {
            player1.money -= store.item3Bundle2Cost;
            inventory1.item3Amount += store.bundle2Amount;
        }
        void CheckMoneyForItem3Bundle2()
        {
            if (player1.money < store.item3Bundle2Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item3Bundle2Cost)
            {
                BuyItem3Bundle2();
            }
        }
        void BuyItem3Bundle3()
        {
            player1.money -= store.item3Bundle3Cost;
            inventory1.item3Amount += store.bundle3Amount;
        }
        void CheckMoneyForItem3Bundle3()
        {
            if (player1.money < store.item3Bundle3Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item3Bundle3Cost)
            {
                BuyItem3Bundle3();
            }
        }
        void BuyItem4Bundle1()
        {
            player1.money -= store.item4Bundle1Cost;
            inventory1.item4Amount += store.bundle1Amount;
        }
        void CheckMoneyForItem4Bundle1()
        {
            if (player1.money < store.item4Bundle1Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item4Bundle1Cost)
            {
                BuyItem4Bundle1();
            }
        }
        void BuyItem4Bundle2()
        {
            player1.money -= store.item4Bundle2Cost;
            inventory1.item4Amount += store.bundle2Amount;
        }
        void CheckMoneyForItem4Bundle2()
        {
            if (player1.money < store.item4Bundle2Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item4Bundle2Cost)
            {
                BuyItem4Bundle2();
            }
        }
        void BuyItem4Bundle3()
        {
            player1.money -= store.item4Bundle3Cost;
            inventory1.item4Amount += store.bundle3Amount;
        }
        void CheckMoneyForItem4Bundle3()
        {
            if (player1.money < store.item4Bundle3Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item4Bundle3Cost)
            {
                BuyItem4Bundle3();
            }
        }
        void ChooseToKeepBuying()
        {
            ClearConsoleLog();
            UI.DisplayPlayer1Inventory();
            UI.DisplayFinishBuyingOption();
            UI.GetUserInput();
            switch (UI.userInput)
            {
                case "1":
                    ChooseBuyingOptions();
                    break;
                case "2":
                    break;
                default:
                    UI.DisplayIncorrectChoice();
                    ChooseToKeepBuying();
                    break;
            }
        }
        void CheckMoneyForItem1()
        {
            if (player1.money < store.item1Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item1Cost)
            {
                BuyItem1();
            }
        }
        void CheckMoneyForItem2()
        {
            if (player1.money < store.item2Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item2Cost)
            {
                BuyItem2();
            }
        }
        void CheckMoneyForItem3()
        {
            if (player1.money < store.item3Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item3Cost)
            {
                BuyItem3();
            }
        }
        void CheckMoneyForItem4()
        {
            if (player1.money < store.item4Cost)
            {
                NotifyLackOfMoney();
            }
            else if (player1.money >= store.item4Cost)
            {
                BuyItem4();
            }
        }
        void NotifyLackOfMoney()
        {
            ClearConsoleLog();
            UI.DisplayLackOfMoney();
            UI.DisplayPressToContinue();
            UI.GetUserInput();
        }
        void BuyItem1()
        {
            UpdateItem1InventorySingle();
            DeductMoneyForItem1();
        }
        void BuyItem2()
        {
            UpdateItem2InventorySingle();
            DeductMoneyForItem2();
        }
        void BuyItem3()
        {
            UpdateItem3InventorySingle();
            DeductMoneyForItem3();
        }
        void BuyItem4()
        {
            UpdateItem4InventorySingle();
            DeductMoneyForItem4();
        }
        void DeductMoneyForItem1()
        {
            player1.money -= store.item1Cost;
        }
        void DeductMoneyForItem2()
        {
            player1.money -= store.item2Cost;
        }
        void DeductMoneyForItem3()
        {
            player1.money -= store.item3Cost;
        }
        void DeductMoneyForItem4()
        {
            player1.money -= store.item4Cost;
        }
        void UpdateItem1InventorySingle()
        {
            (inventory1.item1Amount)++;
        }
        void UpdateItem2InventorySingle()
        {
            (inventory1.item2Amount)++;
        }
        void UpdateItem3InventorySingle()
        {
            (inventory1.item3Amount)++;
        }
        void UpdateItem4InventorySingle()
        {
            (inventory1.item4Amount)++;
        }
        void CheckEndingConditon()
        {
            // when it hits game.days (Amount of days they chose)
        }
        void UpdatCurrentDay()
        {
            day.currentDay++;
        }
       void SetEndDate()
        {
            UI.DisplayEndDateOption();
            UI.GetUserInput();
            player1.chosenEndDate = Convert.ToInt32(UI.userInput);
            CheckEndDateChoie();
        }
        void SetPlayer1Name()
        {
            UI.DisplayPlayer1NameOption();
            UI.GetUserInput();
            player1.name = UI.userInput;
        }
    }
}
