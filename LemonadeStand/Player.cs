﻿using System;
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
        public PiggyBank piggyBank;
        public Store store;
        public Inventory inventory;
        public RecipeBook recipeBook;
        public bool desireToContinue;
        public ReviewBook reviewBook;
        public AttendanceList attendanceList;        
        // make wallet class
        //wallet says I dont have enough money
        // have store say it wont take it without money
        public string input;
        public int chosenEndDate;
        //constructor
        public Player (string name, Store store, Cup item1, Lemon item2, Sugar item3, Ice item4)
        {
            this.name = name;
            this.store = store;
            this.piggyBank = new PiggyBank(store);
            this.inventory = new Inventory(item1, item2, item3, item4, store);
            this.recipeBook = new RecipeBook();
            this.reviewBook = new ReviewBook();
            this.attendanceList = new AttendanceList();
        }

        //methods
        public string SetPlayerInput()
        {
            input = Console.ReadLine();
            return input;
        }

        void CheckSupplies()
        {
            if ((inventory.item1Amount == 0) || (inventory.item2Amount == 0) || (inventory.item3Amount == 0) || (inventory.item4Amount == 0))
            {
                inventory.outOfSupplies = true;
            }
              
        }

        public void ChangeItem1Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                recipeBook.AddToItem1RecipeAmount();
            }
        }
        public void ChangeItem2Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                recipeBook.AddToItem2RecipeAmount();
            }
        }
        public void ChangeItem3Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                recipeBook.AddToItem3RecipeAmount();
            }
        }
        public void ChangeItem4Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                recipeBook.AddToItem4RecipeAmount();
            }
        }
        public void SellProduct()
        {
            inventory.merchandiseSold++;
            piggyBank.totalGainedMoney += recipeBook.cost;
            piggyBank.gainedMoney += recipeBook.cost;
            piggyBank.money += recipeBook.cost;
            SellItem1();
            SellItem2();
            SellItem3();
            SellItem4();
            
        }
        public void SellItem1()
        {
            inventory.item1Sold++;
            recipeBook.item1RecipeAmount = inventory.item1DeductedAmount;
            inventory.DeductItem1RecipeAmount();
        }
        public void SellItem2()
        {
            inventory.item2Sold++;
            recipeBook.item2RecipeAmount = inventory.item2DeductedAmount;
            inventory.DeductItem2RecipeAmount();
        }
        public void SellItem3()
        {
            inventory.item3Sold++;
            recipeBook.item3RecipeAmount = inventory.item3DeductedAmount;
            inventory.DeductItem3RecipeAmount();
        }
        public void SellItem4()
        {
            inventory.item4Sold++;
            recipeBook.item4RecipeAmount = inventory.item4DeductedAmount;
            inventory.DeductItem4RecipeAmount();
        }

        public void BuyItem1()
        {
           inventory.UpdateItem1InventorySingle();
           piggyBank.DeductMoneyForItem1();
        }
        public void BuyItem2()
        {
            inventory.UpdateItem2InventorySingle();
            piggyBank.DeductMoneyForItem2();
        }
        public void BuyItem3()
        {
            inventory.UpdateItem3InventorySingle();
            piggyBank.DeductMoneyForItem3();
        }
        public void BuyItem4()
        {
            inventory.UpdateItem4InventorySingle();
            piggyBank.DeductMoneyForItem4();
        }
        public void BuyItem1Bundle1()
        {
            inventory.UpdateItem1FromBundle1();
            piggyBank.DeductMoneyForItem1Bundle1();
        }
        public void BuyItem1Bundle2()
        {
            inventory.UpdateItem1FromBundle2();
            piggyBank.DeductMoneyForItem1Bundle2();
        }
        public void BuyItem1Bundle3()
        {
            inventory.UpdateItem1FromBundle3();
            piggyBank.DeductMoneyForItem1Bundle3();
        }
        public void BuyItem2Bundle1()
        {
            inventory.UpdateItem2FromBundle1();
            piggyBank.DeductMoneyForItem2Bundle1();
        }
        public void BuyItem2Bundle2()
        {
            inventory.UpdateItem2FromBundle2();
            piggyBank.DeductMoneyForItem2Bundle2();
        }
        public void BuyItem2Bundle3()
        {
            inventory.UpdateItem2FromBundle3();
            piggyBank.DeductMoneyForItem2Bundle3();
        }
        public void BuyItem3Bundle1()
        {
            inventory.UpdateItem3FromBundle1();
            piggyBank.DeductMoneyForItem3Bundle1();
        }
        public void BuyItem3Bundle2()
        {
            inventory.UpdateItem3FromBundle2();
            piggyBank.DeductMoneyForItem3Bundle2();
        }
        public void BuyItem3Bundle3()
        {
            inventory.UpdateItem3FromBundle3();
            piggyBank.DeductMoneyForItem3Bundle3();
        }
        public void BuyItem4Bundle1()
        {
            inventory.UpdateItem4FromBundle1();
            piggyBank.DeductMoneyForItem4Bundle1();
        }
        public void BuyItem4Bundle2()
        {
            inventory.UpdateItem4FromBundle2();
            piggyBank.DeductMoneyForItem4Bundle2();
        }
        public void BuyItem4Bundle3()
        {
            inventory.UpdateItem4FromBundle3();
            piggyBank.DeductMoneyForItem4Bundle3();
        }
    }
}
