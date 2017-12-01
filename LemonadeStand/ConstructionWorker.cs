using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class ConstructionWorker : Customer
    {
        public ConstructionWorker(Player player, Weather weather, string name, string dislikedWeatherType, double dislikedAirTemperature, double dislikedWindSpeed, double dislikedPrecipitation, double favoriteObject1Amount, double favoriteObject2Amount, double favoriteObject3Amount, double favoriteObject4Amount, double dislikedObject1Amount, double dislikedObject2Amount, double dislikedObject3Amount, double dislikedObject4Amount, double maxPay)
            : base(player, weather, name, dislikedWeatherType, dislikedAirTemperature, dislikedWindSpeed, dislikedPrecipitation, favoriteObject1Amount, favoriteObject2Amount, favoriteObject3Amount, favoriteObject4Amount, dislikedObject1Amount, dislikedObject2Amount, dislikedObject3Amount, dislikedObject4Amount, maxPay)
        {
            this.name = name;
            this.dislikedWeatherType = dislikedWeatherType;
            this.dislikedAirTemperature = dislikedAirTemperature;
            this.dislikedWindSpeed = dislikedWindSpeed;
            this.dislikedPrecipitation = dislikedPrecipitation;
            this.favoriteObject1Amount = favoriteObject1Amount;
            this.favoriteObject2Amount = favoriteObject2Amount;
            this.favoriteObject3Amount = favoriteObject3Amount;
            this.favoriteObject4Amount = favoriteObject4Amount;
            this.dislikedObject1Amount = dislikedObject1Amount;
            this.dislikedObject2Amount = dislikedObject2Amount;
            this.dislikedObject3Amount = dislikedObject3Amount;
            this.dislikedObject4Amount = dislikedObject4Amount;
            this.maxPay= maxPay;
        }
    }
}
