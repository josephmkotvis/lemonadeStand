using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public object item1;
        public object item2;
        public object item3;
        public object item4;
        public string item1name;
        public string item2name;
        public string item3name;
        public string item4name;
        public double item1Amount = 0;
        public double item2Amount = 0;
        public double item3Amount = 0;
        public double item4Amount = 0;
        public double item1DeductedAmount;
        public double item2DeductedAmount;
        public double item3DeductedAmount;
        public double item4DeductedAmount;
        public double MerchandiseSold = 0;
        Store store;

        public Inventory( Cup item1, Lemon item2, Sugar item3, Ice item4, Store store)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item1name = item1.name;
            this.item2name = item2.name;
            this.item3name = item3.name;
            this.item4name = item4.name;
            this.store = store;
        }
        void GetInventoryInfos()
        {
            List<string> inventoryItems = new List<string>
            {
                item1name,
                item2name,
                item3name,
                item4name
            };
        }
        public void DeductItem1InventoryAmount()
        {
            item1Amount -= item1DeductedAmount;
        }
        public void DeductItem2InventoryAmount()
        {
            item1Amount -= item2DeductedAmount;
        }
        public void DeductItem3InventoryAmount()
        {
            item1Amount -= item3DeductedAmount;
        }
        public void DeductItem4InventoryAmount()
        {
            item1Amount -= item4DeductedAmount;
        }
        public void DeductItem1InventorySingle()
        {

            (item1Amount)--;
        }
        public void DeductItem2InventorySingle()
        {
            (item2Amount)--;
        }
        public void DeductItem3InventorySingle()
        {
            (item3Amount)--;
        }
        public void DeductItem4InventorySingle()
        {
            (item4Amount)--;
        }

        public void UpdateItem1InventorySingle()
        {
            (item1Amount)++;
        }
        public void UpdateItem2InventorySingle()
        {
            (item2Amount)++;
        }
        public void UpdateItem3InventorySingle()
        {
            (item3Amount)++;
        }
        public void UpdateItem4InventorySingle()
        {
            (item4Amount)++;
        }
        public void UpdateItem1FromBundle1()
        {
            item1Amount += store.bundle1Amount;
        }
        public void UpdateItem1FromBundle2()
        {
            item1Amount += store.bundle2Amount;
        }
        public void UpdateItem1FromBundle3()
        {
            item1Amount += store.bundle3Amount;
        }
        public void UpdateItem2FromBundle1()
        {
            item2Amount += store.bundle1Amount;
        }
        public void UpdateItem2FromBundle2()
        {
            item2Amount += store.bundle2Amount;
        }
        public void UpdateItem2FromBundle3()
        {
            item2Amount += store.bundle3Amount;
        }
        public void UpdateItem3FromBundle1()
        {
            item3Amount += store.bundle1Amount;
        }
        public void UpdateItem3FromBundle2()
        {
            item3Amount += store.bundle2Amount;
        }
        public void UpdateItem3FromBundle3()
        {
            item3Amount += store.bundle3Amount;
        }
        public void UpdateItem4FromBundle1()
        {
            item4Amount += store.bundle1Amount;
        }
        public void UpdateItem4FromBundle2()
        {
            item4Amount += store.bundle2Amount;
        }
        public void UpdateItem4FromBundle3()
        {
            item4Amount += store.bundle3Amount;
        }
    }
}
