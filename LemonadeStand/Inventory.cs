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
        public double merchandiseSold = 0;
        public double item1Sold =0;
        public double item2Sold =0;
        public double item3Sold =0;
        public double item4Sold =0;
        public bool outOfSupplies;
        public Inventory( Cup item1, Lemon item2, Sugar item3, Ice item4)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item1name = item1.name;
            this.item2name = item2.name;
            this.item3name = item3.name;
            this.item4name = item4.name;
        }

       
    }
}
