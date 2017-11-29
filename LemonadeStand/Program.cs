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
            Player player1 = new Player("Player1");
            Lemon lemon = new Lemon();
            Sugar sugar = new Sugar();
            Ice ice = new Ice();
            Cup cup = new Cup();
            Inventory inventory1 = new Inventory("Player1", lemon, sugar, ice, cup);
            Store store = new Store(lemon, sugar, ice, cup);
            Day newDay = new Day();
            UserInterface UI = new UserInterface(player1, inventory1, store, newDay);
            Game gameRound = new Game(UI, player1, newDay, inventory1,store);
            gameRound.RunGame();
            Console.ReadKey();
        }
    }
}
