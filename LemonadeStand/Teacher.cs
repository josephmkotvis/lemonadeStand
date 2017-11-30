using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Teacher : Customer
    {
        string dislikedWeatherType = "Foggy";
        double dislikedAirTemperature = 45;
        double dislikedWindSpeed = 12;
        double dislikedPrecipitation = 14;
        double favoriteObject1Amount = 1;
        double favoriteObject2Amount = 6;
        double favoriteObject3Amount = 4;
        double favoriteObject4Amount = 3;
        double dislikedObject1Amount = 0;
        double dislikedObject2Amount = 1;
        double dislikedObject3Amount = 1;
        double dislikedObject4Amount = 1;
        double maxPay = 10;
        public new bool decisionToBuy;
        public new bool decisionToGo;
        public Teacher(Player player, Weather weather)
            : base(player, weather)
        {

        }
    }
}
