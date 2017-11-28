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
            Player Player1 = new Player("Player1");
            Lemon lemon = new Lemon();
            Sugar sugar = new Sugar();
            Cup cup = new Cup();
            Ice ice = new Ice();
            Inventory Inventory1 = new Inventory("Player1", lemon, sugar, cup, ice);
            Store store = new Store(lemon, sugar, cup, ice);
            Console.ReadKey();
        }
    }
}
