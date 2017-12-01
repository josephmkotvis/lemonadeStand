using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public dynamic item1Bundle1Cost;
        public dynamic item1Bundle2Cost;
        public dynamic item1Bundle3Cost;
        public dynamic item2Bundle1Cost;
        public dynamic item2Bundle2Cost;
        public dynamic item2Bundle3Cost;
        public dynamic item3Bundle1Cost;
        public dynamic item3Bundle2Cost;
        public dynamic item3Bundle3Cost;
        public dynamic item4Bundle1Cost;
        public dynamic item4Bundle2Cost;
        public dynamic item4Bundle3Cost;
        public double bundle1Amount = 10;
        public double bundle2Amount = 25;
        public double bundle3Amount = 50;
        public double bundle1Discount = 0.9;
        public double bundle2Discount = .8;
        public double bundle3Discount = 0.7;
        public object item1;
        public object item2;
        public object item3;
        public object item4;
        public string item1Name;
        public string item2Name;
        public string item3Name;
        public string item4Name;
        public double item1Cost;
        public double item2Cost;
        public double item3Cost;
        public double item4Cost;

        public Store(Cup item1,Lemon  item2,Sugar item3,Ice item4)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item1Name = item1.name;
            this.item2Name = item2.name;
            this.item3Name = item3.name;
            this.item4Name = item4.name;
            this.item1Cost = item1.cost;
            this.item2Cost = item2.cost;
            this.item3Cost = item3.cost;
            this.item4Cost = item4.cost;
            item1Bundle1Cost = ((item1.cost * bundle1Amount) * bundle1Discount);
            item1Bundle2Cost = ((item1.cost * bundle2Amount) * bundle2Discount);
            item1Bundle3Cost = ((item1.cost * bundle3Amount) * bundle3Discount);
            item2Bundle1Cost = ((item2.cost * bundle1Amount) * bundle1Discount);
            item2Bundle2Cost = ((item2.cost * bundle2Amount) * bundle2Discount);
            item2Bundle3Cost = ((item2.cost * bundle3Amount) * bundle3Discount);
            item3Bundle1Cost = ((item3.cost * bundle1Amount) * bundle1Discount);
            item3Bundle2Cost = ((item3.cost * bundle2Amount) * bundle2Discount);
            item3Bundle3Cost = ((item3.cost * bundle3Amount) * bundle3Discount);
            item4Bundle1Cost = ((item4.cost * bundle1Amount) * bundle1Discount);
            item4Bundle2Cost = ((item4.cost * bundle2Amount) * bundle2Discount);
            item4Bundle3Cost = ((item4.cost * bundle3Amount) * bundle3Discount);
        }
        void GetStoreInventoryWithPrice()
        {
            List<Object> inventoryItems = new List<Object>
            {
                item1,
                item2,
                item3,
                item4
            };
        } 


    }
}
