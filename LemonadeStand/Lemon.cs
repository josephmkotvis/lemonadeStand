using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon : Item
    {
        public string lemonName = "Lemon";
        public decimal lemonCost = 4;
        public dynamic lemonBundleCost1;
        public dynamic lemonBundleCost2;
        public dynamic lemonBundleCost3;
        public Lemon()
        {
            lemonBundleCost1 = ((lemonCost * bundleAmount1) * bundle1Discount);
            lemonBundleCost2 = ((lemonCost * bundleAmount2) * bundle2Discount);
            lemonBundleCost3 = ((lemonCost * bundleAmount3) * bundle3Discount);
        }
    }
}
