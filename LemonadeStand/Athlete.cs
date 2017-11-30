using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Athlete : Customer
    {
        string dislikedWeatherType = "Snow";
        double dislikedAirTemperature = 10;
        double dislikedWindSpeed = 18;
        double dislikedPrecipitation = 2;
        double favoriteObject1Amount = 1;
        double favoriteObject2Amount = 4;
        double favoriteObject3Amount = 0;
        double favoriteObject4Amount = 25;
        double dislikedObject1Amount = 0;
        double dislikedObject2Amount = 2;
        double dislikedObject3Amount = 3;
        double dislikedObject4Amount = 0;
        double maxPay = 10;
        public new bool decisionToBuy;
        public new bool decisionToGo;
        public Athlete(Player player, Weather weather)
            : base(player, weather)
        {

        }
    }
}
