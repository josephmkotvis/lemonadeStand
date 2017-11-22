using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Item
    {
        // member variables
        string name;
        decimal cost;
        decimal bundleCost1;
        decimal bundleCost2;
        decimal bundleCost3;
        double bundleAmount1;
        double bundleAmount2;
        double bundleAmount3;
        // will be a string of objects
        //constructor
        public Item (string name, decimal cost, decimal bundleCost1, decimal bundleCost2, decimal bundleCost3, double bundleAmount1, double bundleAmount2, double bundleAmount3)
        {
            this.name = name;
            this.cost = cost;
            this.bundleCost1 = bundleCost1;
            this.bundleCost2 = bundleCost2;
            this.bundleCost3 = bundleCost3;
            this.bundleAmount1 = bundleAmount1;
            this.bundleAmount2 = bundleAmount2;
            this.bundleAmount3 = bundleAmount3;
        }

        //methods


    }
}
