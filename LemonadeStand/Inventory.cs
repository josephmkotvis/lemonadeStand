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
        public string item1name;
        public string item2name;
        public string item3name;
        public string item4name;
        public decimal item1Amount = 0;
        public decimal item2Amount = 0;
        public decimal item3Amount = 0;
        public decimal item4Amount = 0;

        public Inventory(string owner, Lemon item1, Sugar item2, Ice item3, Cup item4)
        {
            this.owner = owner;
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item1name = item1.name;
            this.item2name = item2.name;
            this.item3name = item3.name;
            this.item4name = item4.name;
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
    }
}
