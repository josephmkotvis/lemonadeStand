﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public dynamic item1BundleCost1;
        public dynamic item1BundleCost2;
        public dynamic item1BundleCost3;
        public dynamic item2BundleCost1;
        public dynamic item2BundleCost2;
        public dynamic item2BundleCost3;
        public dynamic item3BundleCost1;
        public dynamic item3BundleCost2;
        public dynamic item3BundleCost3;
        public dynamic item4BundleCost1;
        public dynamic item4BundleCost2;
        public dynamic item4BundleCost3;
        public decimal bundleAmount1 = 10;
        public decimal bundleAmount2 = 25;
        public decimal bundleAmount3 = 50;
        public decimal bundle1Discount = 0.1M;
        public decimal bundle2Discount = 0.2M;
        public decimal bundle3Discount = 0.4M;
        private object item1;
        private object item2;
        private object item3;
        private object item4;

        public Store(Lemon item1,Sugar  item2,Cup item3,Ice item4)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            item1BundleCost1 = ((item1.cost * bundleAmount1) * bundle1Discount);
            item1BundleCost2 = ((item1.cost * bundleAmount2) * bundle2Discount);
            item1BundleCost3 = ((item1.cost * bundleAmount3) * bundle3Discount);
            item2BundleCost1 = ((item2.cost * bundleAmount1) * bundle1Discount);
            item2BundleCost2 = ((item2.cost * bundleAmount2) * bundle2Discount);
            item2BundleCost3 = ((item2.cost * bundleAmount3) * bundle3Discount);
            item3BundleCost1 = ((item3.cost * bundleAmount1) * bundle1Discount);
            item3BundleCost2 = ((item3.cost * bundleAmount2) * bundle2Discount);
            item3BundleCost3 = ((item3.cost * bundleAmount3) * bundle3Discount);
            item4BundleCost1 = ((item4.cost * bundleAmount1) * bundle1Discount);
            item4BundleCost2 = ((item4.cost * bundleAmount2) * bundle2Discount);
            item4BundleCost3 = ((item4.cost * bundleAmount3) * bundle3Discount);
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
