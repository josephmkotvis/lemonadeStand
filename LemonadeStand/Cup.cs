using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cup : Item
    {
        public string cupName = "Cup";
        public decimal cupCost = 2;
        public dynamic cupBundleCost1;
        public dynamic cupBundleCost2;
        public dynamic cupBundleCost3;

        public Cup()
        {
            cupBundleCost1 = ((cupCost * bundleAmount1) * bundle1Discount);
            cupBundleCost2 = ((cupCost * bundleAmount2) * bundle2Discount);
            cupBundleCost3 = ((cupCost * bundleAmount3) * bundle3Discount);
        }
    }
}   
