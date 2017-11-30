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
        public PiggyBank piggyBank;
        public Store store;
        public Inventory inventory;
        public RecipeBook recipeBook;
        public bool desireToContinue;
        
        // make wallet class
        //wallet says I dont have enough money
        // have store say it wont take it without money
        public string input;
        public int chosenEndDate;
        //constructor
        public Player (string name, Store store, Lemon lemon, Sugar sugar, Ice ice, Cup cup)
        {
            this.name = name;
            this.store = store;
            this.piggyBank = new PiggyBank(store);
            this.inventory = new Inventory(lemon, sugar, ice, cup, store);
            this.recipeBook = new RecipeBook();
        }

        //methods
        public string SetPlayerInput()
        {
            input = Console.ReadLine();
            return input;
        }
        public void ChangeItem1Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber < 0)
            {
                recipeBook.AddToItem1RecipeAmount();
                inventory.DeductItem1InventorySingle();
            }
        }
        public void ChangeItem2Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber < 0)
            {
                recipeBook.AddToItem2RecipeAmount();
                inventory.DeductItem2InventorySingle();
            }
        }
        public void ChangeItem3Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber < 0)
            {
                recipeBook.AddToItem3RecipeAmount();
                inventory.DeductItem3InventorySingle();
            }
        }
        public void ChangeItem4Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber < 0)
            {
                recipeBook.AddToItem4RecipeAmount();
                inventory.DeductItem4InventorySingle();
            }
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
