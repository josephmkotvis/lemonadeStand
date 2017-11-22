using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Item Cup = new Item ("Cup", 3, 3, 3, 3, 10, 25, 50);
            Item Lemon = new Item("Lemon", 4, 4, 4, 4, 10, 25, 50);
            Item Sugar = new Item("Sugar", 2, 2, 2, 2, 10, 25, 50);
            Item Ice = new Item("Ice", 1, 1, 1, 1, 10, 25, 50);
            List<Item> Items = new List<Item>
            {
                Cup,
                Lemon,
                Sugar,
                Ice
            };
        }
    }
}
