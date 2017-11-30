using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class ConstructionWorker : Customer
    {
        string dislikedWeatherType = "Windy";
        double dislikedAirTemperature = 90;
        double dislikedWindSpeed = 35;
        double dislikedPrecipitation = 0;
        double favoriteObject1Amount = 1;
        double favoriteObject2Amount = 13;
        double favoriteObject3Amount = 10;
        double favoriteObject4Amount = 14;
        double dislikedObject1Amount = 0;
        double dislikedObject2Amount = 4;
        double dislikedObject3Amount = 8;
        double dislikedObject4Amount = 0;
        double maxPay = 7;
        public new bool decisionToBuy;
        public new bool decisionToGo;
        public ConstructionWorker(Player player, Weather weather)
            : base(player, weather)
        {

        }
    }
}
