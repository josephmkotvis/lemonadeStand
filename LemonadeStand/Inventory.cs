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
        Lemon lemon;
        Sugar sugar;
        Ice ice;
        Cup cup;
        double lemonAmount = 0;
        double sugarAmount = 0;
        double iceAmount = 0;
        double cupAmount = 0;

        public Inventory(string owner)
        {
            this.owner = owner;
        }
        void GetInventoryInfos()
        {
            List<Item> inventoryItems = new List<Item>
            {
                lemon,
                sugar,
                ice,
                cup
            };
        }
        void GetInventoryAmounts()
        {
            List<double> inventoryItemsAmounts = new List<double>
            {
                lemonAmount,
                sugarAmount,
                iceAmount,
                cupAmount,

            };
        }
    }
}
