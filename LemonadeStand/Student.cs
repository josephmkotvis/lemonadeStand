using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Student : Customer
    {
        string dislikedWeatherType = "Hail";
        double dislikedAirTemperature = 34;
        double dislikedWindSpeed = 12;
        double dislikedPrecipitation = 5;
        double favoriteObject1Amount = 1;
        double favoriteObject2Amount = 15;
        double favoriteObject3Amount = 20;
        double favoriteObject4Amount = 3;
        double dislikedObject1Amount = 0;
        double dislikedObject2Amount = 8;
        double dislikedObject3Amount = 13;
        double dislikedObject4Amount = 12;
        double maxPay = 1;
        public new bool decisionToBuy;
        public new bool decisionToGo;
        public Student(Player player, Weather weather)
            : base(player, weather)
        {

        }
    }
}
