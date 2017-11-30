using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        string dislikedWeatherType;
        double dislikedAirTemperature;
        double dislikedWindSpeed;
        double dislikedPrecipitation;
        double dislikedObject1Amount;
        double dislikedObject2Amount;
        double dislikedObject3Amount;
        public bool decisionToBuy;
        public bool decisionToGo = true;
       

        Player player;
        Weather weather;
        ComplaintBook complaintBook;
        AttendanceList attendanceList;

        public Customer(Player player, Weather weather, ComplaintBook complaintBook, AttendanceList attendanceList)
        {
            this.player = player;
            this.weather = weather;
            this.complaintBook = complaintBook;
            this.attendanceList = attendanceList;
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
        void DecideToGo()
        {
            ThinkABoutWeatherType();
            ThinkAboutTemp();
            ThinkAboutWindSpeed();
            ThinkAboutPrecipitation();
            if (decisionToGo == true)
            {
                ThinkAboutBuying();
            }
        }
        void DecideToBuy()
        {
            if (decisionToBuy == true)
            {
                AttemptToBuy();
            }
            else if (decisionToBuy == false)
            {
                DecideNotToBuyFromDislike();
            }
        }
        void AttemptToBuy()
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
        void DecideNotToBuyFromDislike()
        {
            ComplainAboutDislike();
        }
        void ThinkABoutWeatherType()
        {
            if (weather.weatherType == dislikedWeatherType)
            {
                complaintBook.complaintsAboutWeather++;
                decisionToGo = false;
            }
        }
        void ThinkAboutTemp()
        {
            if (weather.airTemperature == dislikedAirTemperature)
            {
                decisionToGo = false;
            }
        }
        void ThinkAboutWindSpeed()
        {
            if (weather.airTemperature == dislikedWindSpeed)
            {
                decisionToGo = false;
            }
        }
        void ThinkAboutPrecipitation()
        {
            if (weather.precipitation == dislikedPrecipitation)
            {
                decisionToGo = false;
            }

        }
    }
}
