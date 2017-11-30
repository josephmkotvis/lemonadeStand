﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Teacher : Customer
    {
        string dislikedWeatherType = "Foggy";
        double dislikedAirTemperature = 15;
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
        public Teacher(Player player, Weather weather, string dislikedWeatherType, double dislikedAirTemperature, double dislikedWindSpeed, double dislikedPrecipitation, double favoriteObject1Amount, double favoriteObject2Amount, double favoriteObject3Amount, double favoriteObject4Amount, double dislikedObject1Amount, double dislikedObject2Amount, double dislikedObject3Amount, double dislikedObject4Amount, double maxPay, bool decisionToBuy, bool decisionToGo)
            : base(player,  weather)
        {
            this.dislikedWeatherType = dislikedWeatherType;
            this.dislikedAirTemperature = dislikedAirTemperature;
            this.dislikedPrecipitation = dislikedPrecipitation;
            this.dislikedWindSpeed = dislikedWindSpeed;
            this.favoriteObject1Amount = favoriteObject1Amount;
            this.favoriteObject2Amount = favoriteObject2Amount;
            this.favoriteObject3Amount = favoriteObject3Amount;
            this.favoriteObject4Amount = favoriteObject4Amount;
            this.dislikedObject1Amount = dislikedObject1Amount;
            this.dislikedObject2Amount = dislikedObject2Amount;
            this.dislikedObject3Amount = dislikedObject3Amount;
            this.dislikedObject4Amount = dislikedObject4Amount;

        }
    }
}
