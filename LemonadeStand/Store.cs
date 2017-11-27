using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        Lemon lemon;
        Sugar sugar;
        Ice ice;
        Cup cup;
        
        void GetStoreInventoryInfo()
        {             
            List<Item> inventoryItems = new List<Item>
            {
              lemon,
              sugar,
              ice,
              cup
            };
        }
    }
}
