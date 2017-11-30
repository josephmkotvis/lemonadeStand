using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Millionare : Customer
    {
        string dislikedWeatherType = "None";
        double dislikedAirTemperature = 100;
        double dislikedWindSpeed = 30;
        double dislikedPrecipitation = 12;
        double favoriteObject1Amount = 500;
        double favoriteObject2Amount = 500;
        double favoriteObject3Amount = 500;
        double favoriteObject4Amount = 500;
        double dislikedObject1Amount = 0;
        double dislikedObject2Amount = 0;
        double dislikedObject3Amount = 0;
        double dislikedObject4Amount = 0;
        double maxPay = 0;
        public new bool decisionToBuy;
        public new bool decisionToGo;
        public Millionare(Player player, Weather weather)
            : base(player, weather)
        {

        }
        void TakeAllForZero()
        {
            player.inventory.item1Amount = 0;
            player.inventory.item2Amount = 0;
            player.inventory.item3Amount = 0;
            player.inventory.item4Amount = 0;
        }
    }
}
