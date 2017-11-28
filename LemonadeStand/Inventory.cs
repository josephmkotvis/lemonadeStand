using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        string owner;
        public object item1;
        public object item2;
        public object item3;
        public object item4;
        double lemonAmount = 0;
        double sugarAmount = 0;
        double iceAmount = 0;
        double cupAmount = 0;

        public Inventory(string owner, Lemon item1, Sugar item2, Cup item3, Ice item4)
        {
            this.owner = owner;
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
        }
        void GetInventoryInfos()
        {
            List<string> inventoryItems = new List<string>
            {
                item1.name,
                item2.name,
                item3.name,
                item4.name
            };
        }
    }
}
