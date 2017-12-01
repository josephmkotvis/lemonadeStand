using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public PiggyBank piggyBank;
        public Store store;
        public Inventory inventory;
        public RecipeBook recipeBook;
        public bool desireToContinue;
        public ReviewBook reviewBook;
        public AttendanceList attendanceList;        
        public string input;
        public int chosenEndDate;
        public Player (string name, Store store, Cup item1, Lemon item2, Sugar item3, Ice item4)
        {
            this.name = name;
            this.store = store;
            this.piggyBank = new PiggyBank(store);
            this.inventory = new Inventory(item1, item2, item3, item4);
            this.recipeBook = new RecipeBook();
            this.reviewBook = new ReviewBook();
            this.attendanceList = new AttendanceList();
        }
        public string SetPlayerInput()
        {
            input = Console.ReadLine();
            return input;
        }
        public void ChangeItem1Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                AddToItem1RecipeAmount();
            }
        }
        public void ChangeItem2Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                AddToItem2RecipeAmount();
            }
        }
        public void ChangeItem3Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                AddToItem3RecipeAmount();
            }
        }
        public void ChangeItem4Recipe()
        {
            if (recipeBook.playerRecipeChangeNumber > 0)
            {
                AddToItem4RecipeAmount();
            }
        }
        public void AddToItem1RecipeAmount()
        {
            recipeBook.item1RecipeAmount += recipeBook.playerRecipeChangeNumber;
        }
        public void AddToItem2RecipeAmount()
        {
            recipeBook.item2RecipeAmount += recipeBook.playerRecipeChangeNumber;
        }
        public void AddToItem3RecipeAmount()
        {
            recipeBook.item3RecipeAmount += recipeBook.playerRecipeChangeNumber;
        }
        public void AddToItem4RecipeAmount()
        {
            recipeBook.item4RecipeAmount += recipeBook.playerRecipeChangeNumber;
        }
        public void CheckForStock()
        {
            if ((recipeBook.item1RecipeAmount > inventory.item1Amount) || (recipeBook.item2RecipeAmount > inventory.item2Amount) || (recipeBook.item3RecipeAmount > inventory.item3Amount) || (recipeBook.item4RecipeAmount > inventory.item4Amount))
                {
                inventory.outOfSupplies = true;
                }
        }
        public void SellToCustomer()
        {
            CheckForStock();
            if (inventory.outOfSupplies == false)
            {
                SellProduct();
                LogSale();
            }
        }
        public void SellProduct()
        {
            SellItem1();
            SellItem2();
            SellItem3();
            SellItem4();
        }
        public void LogSale()
        {
            inventory.merchandiseSold++;
            piggyBank.totalGainedMoney += recipeBook.cost;
            piggyBank.gainedMoney += recipeBook.cost;
            piggyBank.money += recipeBook.cost;
        }
        public void SellItem1()
        {
            inventory.item1Sold++;
            DeductItem1RecipeAmount();
        }
        public void SellItem2()
        {
            inventory.item2Sold++;
            DeductItem2RecipeAmount();
        }
        public void SellItem3()
        {
            inventory.item3Sold++;
            DeductItem3RecipeAmount();
        }
        public void SellItem4()
        {
            inventory.item4Sold++;
            DeductItem4RecipeAmount();
        }

        public void BuyItem1()
        {
           UpdateItem1InventorySingle();
           piggyBank.DeductMoneyForItem1();
        }
        public void BuyItem2()
        {
            UpdateItem2InventorySingle();
            piggyBank.DeductMoneyForItem2();
        }
        public void BuyItem3()
        {
            UpdateItem3InventorySingle();
            piggyBank.DeductMoneyForItem3();
        }
        public void BuyItem4()
        {
            UpdateItem4InventorySingle();
            piggyBank.DeductMoneyForItem4();
        }
        public void BuyItem1Bundle1()
        {
            UpdateItem1FromBundle1();
            piggyBank.DeductMoneyForItem1Bundle1();
        }
        public void BuyItem1Bundle2()
        {
            UpdateItem1FromBundle2();
            piggyBank.DeductMoneyForItem1Bundle2();
        }
        public void BuyItem1Bundle3()
        {
            UpdateItem1FromBundle3();
            piggyBank.DeductMoneyForItem1Bundle3();
        }
        public void BuyItem2Bundle1()
        {
            UpdateItem2FromBundle1();
            piggyBank.DeductMoneyForItem2Bundle1();
        }
        public void BuyItem2Bundle2()
        {
            UpdateItem2FromBundle2();
            piggyBank.DeductMoneyForItem2Bundle2();
        }
        public void BuyItem2Bundle3()
        {
            UpdateItem2FromBundle3();
            piggyBank.DeductMoneyForItem2Bundle3();
        }
        public void BuyItem3Bundle1()
        {
            UpdateItem3FromBundle1();
            piggyBank.DeductMoneyForItem3Bundle1();
        }
        public void BuyItem3Bundle2()
        {
            UpdateItem3FromBundle2();
            piggyBank.DeductMoneyForItem3Bundle2();
        }
        public void BuyItem3Bundle3()
        {
            UpdateItem3FromBundle3();
            piggyBank.DeductMoneyForItem3Bundle3();
        }
        public void BuyItem4Bundle1()
        {
            UpdateItem4FromBundle1();
            piggyBank.DeductMoneyForItem4Bundle1();
        }
        public void BuyItem4Bundle2()
        {
            UpdateItem4FromBundle2();
            piggyBank.DeductMoneyForItem4Bundle2();
        }
        public void BuyItem4Bundle3()
        {
            UpdateItem4FromBundle3();
            piggyBank.DeductMoneyForItem4Bundle3();
        }
        public void DeductItem1RecipeAmount()
        {
            inventory.item1Amount -= recipeBook.item1RecipeAmount;
        }
        public void DeductItem2RecipeAmount()
        {
            inventory.item2Amount -= recipeBook.item2RecipeAmount;
        }
        public void DeductItem3RecipeAmount()
        {
            inventory.item3Amount -= recipeBook.item3RecipeAmount;
        }
        public void DeductItem4RecipeAmount()
        {
            inventory.item4Amount -= recipeBook.item4RecipeAmount;
        }
        public void DeductItem1InventorySingle()
        {
            (inventory.item1Amount)--;
        }
        public void DeductItem2InventorySingle()
        {
            (inventory.item2Amount)--;
        }
        public void DeductItem3InventorySingle()
        {
            (inventory.item3Amount)--;
        }
        public void DeductItem4InventorySingle()
        {
            (inventory.item4Amount)--;
        }
        public void UpdateItem1InventorySingle()
        {
            (inventory.item1Amount)++;
        }
        public void UpdateItem2InventorySingle()
        {
            (inventory.item2Amount)++;
        }
        public void UpdateItem3InventorySingle()
        {
            (inventory.item3Amount)++;
        }
        public void UpdateItem4InventorySingle()
        {
            (inventory.item4Amount)++;
        }
        public void UpdateItem1FromBundle1()
        {
            inventory.item1Amount += store.bundle1Amount;
        }
        public void UpdateItem1FromBundle2()
        {
            inventory.item1Amount += store.bundle2Amount;
        }
        public void UpdateItem1FromBundle3()
        {
            inventory.item1Amount += store.bundle3Amount;
        }
        public void UpdateItem2FromBundle1()
        {
            inventory.item2Amount += store.bundle1Amount;
        }
        public void UpdateItem2FromBundle2()
        {
            inventory.item2Amount += store.bundle2Amount;
        }
        public void UpdateItem2FromBundle3()
        {
            inventory.item2Amount += store.bundle3Amount;
        }
        public void UpdateItem3FromBundle1()
        {
            inventory.item3Amount += store.bundle1Amount;
        }
        public void UpdateItem3FromBundle2()
        {
            inventory.item3Amount += store.bundle2Amount;
        }
        public void UpdateItem3FromBundle3()
        {
            inventory.item3Amount += store.bundle3Amount;
        }
        public void UpdateItem4FromBundle1()
        {
            inventory.item4Amount += store.bundle1Amount;
        }
        public void UpdateItem4FromBundle2()
        {
            inventory.item4Amount += store.bundle2Amount;
        }
        public void UpdateItem4FromBundle3()
        {
            inventory.item4Amount += store.bundle3Amount;
        }
    }
}
