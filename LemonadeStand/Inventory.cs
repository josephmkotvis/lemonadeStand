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

        public Inventory(string owner)
        {
            this.owner = owner;
        }
        void InventoryItems()
        {
        List<Item> inventoryItems = new List<Item>();
        inventoryItems.Add(new Item("Cup", 3, 3, 3, 3, 10, 25, 50));
        inventoryItems.Add(new Item("Lemon", 4, 4, 4, 4, 10, 25, 50));
        inventoryItems.Add(new Item("Sugar", 2, 2, 2, 2, 10, 25, 50));
        inventoryItems.Add(new Item("Ice", 1, 1, 1, 1, 10, 25, 50));
        }
    }
}
