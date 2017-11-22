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
            Item Cup = new Item ("Cup", 3);
            Item Lemon = new Item("Lemon", 4);
            Item Sugar = new Item("Sugar", 2);
            Item Ice = new Item("Ice", 1);
            List<Item> Items = new List<Item>();
            Items.Add(Cup);
            Items.Add(Lemon);
            Items.Add(Sugar);
            Items.Add(Ice);
        }
    }
}
