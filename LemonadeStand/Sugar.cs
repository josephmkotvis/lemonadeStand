using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Item
    {
        public string sugarName = "Sugar";
        public decimal sugarCost = 3;
        public dynamic sugarBundleCost1;
        public dynamic sugarBundleCost2;
        public dynamic sugarBundleCost3;
        public Sugar()
        {
            sugarBundleCost1 = ((sugarCost * bundleAmount1) * bundle1Discount);
            sugarBundleCost2 = ((sugarCost * bundleAmount2) * bundle2Discount);
            sugarBundleCost3 = ((sugarCost * bundleAmount3) * bundle3Discount);
        }
    }
}
