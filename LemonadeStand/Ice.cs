using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice : Item
    {
        public string iceName = "ice";
        public decimal iceCost = 1;
        public dynamic iceBundleCost1;
        public dynamic iceBundleCost2;
        public dynamic iceBundleCost3;
        public Ice()
        {
            iceBundleCost1 = ((iceCost * bundleAmount1) * bundle1Discount);
            iceBundleCost2 = ((iceCost * bundleAmount2) * bundle2Discount);
            iceBundleCost3 = ((iceCost * bundleAmount3) * bundle3Discount);
        }
    }
}
 