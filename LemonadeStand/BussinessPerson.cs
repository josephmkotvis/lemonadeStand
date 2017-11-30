using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class BussinessPerson : Customer
    {
        string dislikedWeatherType = "Sunny";
        double dislikedAirTemperature = 65;
        double dislikedWindSpeed = 10;
        double dislikedPrecipitation = 3;
        double favoriteObject1Amount = 1;
        double favoriteObject2Amount = 9;
        double favoriteObject3Amount = 6;
        double favoriteObject4Amount = 3;
        double dislikedObject1Amount = 0;
        double dislikedObject2Amount = 12;
        double dislikedObject3Amount = 14;
        double dislikedObject4Amount = 2;
        double maxPay = 26;
        public new bool decisionToBuy;
        public new bool decisionToGo;
        public BussinessPerson(Player player, Weather weather)
            : base(player, weather)
        {

        }

    }
}
