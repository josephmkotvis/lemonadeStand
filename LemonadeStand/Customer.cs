using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        string favoriteWeatherType;
        string dislikedWeatherType;
        double favoriteAirTemperature;
        double dislikedAirTemperature;
        double favoriteWindSpeed;
        double dislikedWindSpeed;
        double favoritePrecipitation;
        double dislikedPrecipitation;
        double favoriteObject1Amount;
        double favoriteObject2Amount;
        double favoriteObject3Amount;
        double dislikedObject1Amount;
        double dislikedObject2Amount;
        double dislikedObject3Amount;
        public bool decisionToBuy;
        public bool decisionIsMade;

        Player player;
        Weather weather;
        ComplaintBook complaintBook;

        public Customer(Player player, Weather weather, ComplaintBook complaintBook)
        {
            this.player = player;
            this.weather = weather;
            this.complaintBook = complaintBook;
        }
        void BuyDrink()
        {
            player.inventory.MerchandiseSold++;
        }
        void ComplainAboutNoDrinks()
        {
            complaintBook.complaintsAboutNoDrinks++;
        }
        void ComplainAboutDislike()
        {
            complaintBook.complaintsAboutFlavor++;
        }
        void ThinkAboutBuying()
        {
            do
            {
                ThinkABoutWeatherType();
                ThinkAboutTemp();
                ThinkAboutWindSpeed();
                ThinkAboutPrecipitation();
            } while (decisionIsMade == false);

        }
        void MakeDecisionOnBuying()
        {
            if (decisionToBuy == false)
            {
                DecideToBuy();
            }
            else if (decisionToBuy == true)
            {
                DecideNotToBuy();
            }
        }
        void DecideToBuy()
        {
            if (player.inventory.item1Amount == 0)
            {
                ComplainAboutNoDrinks();
            }
            else
            {
                BuyDrink();
            }
        }
        void DecideNotToBuy()
        {
            ComplainAboutDislike();
        }
        void ThinkABoutWeatherType()
        {
            if (weather.weatherType == favoriteWeatherType)
            {
                decisionToBuy = true;
            }
            else if (weather.weatherType == dislikedWeatherType)
            {
                complaintBook.complaintsAboutWeather++;
                decisionToBuy = false;

            }
        }
        void ThinkAboutTemp()
        {
            if (weather.airTemperature == favoriteAirTemperature)
            {
                decisionToBuy = true;
            }
            else if (weather.airTemperature == dislikedAirTemperature)
            {
                decisionToBuy = false;
            }
        }
        void ThinkAboutWindSpeed()
        {
            if (weather.windSpeed == favoriteWindSpeed)
            {
                decisionToBuy = true;
            }
            else if (weather.airTemperature == dislikedWindSpeed)
            {
                decisionToBuy = false;
            }
        }
        void ThinkAboutPrecipitation()
        {
            if (weather.precipitation == favoritePrecipitation)
            {
                decisionToBuy = true;
            }
            if (weather.precipitation == dislikedPrecipitation)
            {
                decisionToBuy = false;
            }

        }
    }
}
