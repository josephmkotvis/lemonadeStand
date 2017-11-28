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
            List<string> inventoryItems = new List<string>
            {
                lemon.name,
                sugar.name,
                ice.name,
                cup.name
            };
        }
    }
}
