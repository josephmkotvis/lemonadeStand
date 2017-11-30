using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Banker : Customer
    {
        string dislikedWeatherType = "Rain";
        double dislikedAirTemperature = 80;
        double dislikedWindSpeed = 30;
        double dislikedPrecipitation = 10;
        double favoriteObject1Amount = 1;
        double favoriteObject2Amount = 2;
        double favoriteObject3Amount = 5;
        double favoriteObject4Amount = 1;
        double dislikedObject1Amount = 0;
        double dislikedObject2Amount = 8;
        double dislikedObject3Amount = 10;
        double dislikedObject4Amount = 4;
        double maxPay = 16;
        public new bool decisionToBuy;
        public new bool decisionToGo;
        public Banker(Player player, Weather weather)
            : base(player, weather)
        {

        }
    }
}
