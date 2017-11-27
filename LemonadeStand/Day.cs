using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        List<int> Days = new List<int>();
        void ListDays()
        {
            for (int day = 0; day < 100; day++)
            {
                Days.Add(day);
            }
        }
    } 
}
