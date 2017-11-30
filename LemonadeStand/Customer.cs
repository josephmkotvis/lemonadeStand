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
        double favoriteObject1Amount;
        double favoriteObject2Amount;
        double favoriteObject3Amount;
        double favoriteObject4Amount;
        double dislikedObject1Amount;
        double dislikedObject2Amount;
        double dislikedObject3Amount;
        double dislikedObject4Amount;
        double maxPay;
        public bool decisionToBuy;
        public bool decisionToGo;
        protected Player player;
        protected Weather weather;

        public Customer(Player player, Weather weather)
        {
            this.player = player;
            this.weather = weather;
        }
        void DecideOnTaste()
        {
            TasteObject1InProduct();
            TasteObject2InProduct();
            TasteObject3InProduct();
            TasteObject4InProduct();
        }
        void TasteObject1InProduct()
        {
            if (dislikedObject1Amount == player.recipeBook.item1RecipeAmount)
            {
                ComplainAboutItem1();
            }
            else if (favoriteObject1Amount == player.recipeBook.item1RecipeAmount)
            {
                ComplimentAboutItem1();
            }
        }
        void TasteObject2InProduct()
        {
            if (dislikedObject2Amount == player.recipeBook.item2RecipeAmount)
            {
                ComplainAboutItem2();
            }
            else if (favoriteObject2Amount == player.recipeBook.item2RecipeAmount)
            {
                ComplimentAboutItem2();
            }
        }
        void TasteObject3InProduct()
        {
            if (dislikedObject3Amount == player.recipeBook.item3RecipeAmount)
            {
                ComplainAboutItem3();
            }
            else if (favoriteObject3Amount == player.recipeBook.item3RecipeAmount)
            {
                ComplimentAboutItem3();
            }
        }
        void TasteObject4InProduct()
        {
            if (dislikedObject4Amount == player.recipeBook.item4RecipeAmount)
            {
                ComplainAboutItem4();
            }
            else if (favoriteObject4Amount == player.recipeBook.item4RecipeAmount)
            {
                ComplimentAboutItem4();
            }
        }
        void ComplainAboutItem1()
        {
                player.reviewBook.complaintsAboutObject1++;
        }
        void ComplainAboutItem2()
        {
            player.reviewBook.complaintsAboutObject2++;
        }
        void ComplainAboutItem3()
        {
                player.reviewBook.complaintsAboutObject3++;
        }
        void ComplainAboutItem4()
        {
                player.reviewBook.complaintsAboutObject4++;
        }
        void ComplimentAboutItem1()
        {
            player.reviewBook.complimentsAboutObject1++;

        }
        void ComplimentAboutItem2()
        {
            player.reviewBook.complimentsAboutObject2++;

        }
        void ComplimentAboutItem3()
        {
            player.reviewBook.complimentsAboutObject3++;

        }
        void ComplimentAboutItem4()
        {
            player.reviewBook.complimentsAboutObject4++;

        }
        void ThinkAboutBuying()
        {
            ThinkAboutPrice();
            DecideIfBuying();
        }
        void ThinkAboutPrice()
        {
            if (player.recipeBook.cost < maxPay)
            {
                decisionToBuy = true;
            }
            else
            {
                player.reviewBook.complaintsAboutPrice++;
            }
        }
        void BuyDrink()
        {
            player.inventory.MerchandiseSold++;
        }
        void ComplainAboutNoDrinks()
        {
            player.reviewBook.complaintsAboutNoDrinks++;
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
        void DecideIfBuying()
        {
            if (decisionToBuy == true)
            {
                AttemptToBuy();
            }
            else if (decisionToBuy == false)
            {
                DecideNotToBuy();
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
        void ComplainAboutWeather()
        {
            player.reviewBook.complaintsAboutWeather++;
        }
        void DecideNotToBuy()
        {
            player.attendanceList.amountOfCustomersToNotAttend++;
        }
        void ThinkABoutWeatherType()
        {
            if (weather.weatherType != dislikedWeatherType)
            {
                decisionToGo = true;
            }
            else
            {
                ComplainAboutWeather();
            }
        }
        void ThinkAboutTemp()
        {
            if (weather.airTemperature != dislikedAirTemperature)
            {
                decisionToGo = true;
            }
            else
            {
                ComplainAboutWeather();
            }
        }
        void ThinkAboutWindSpeed()
        {
            if (weather.airTemperature != dislikedWindSpeed)
            {
                decisionToGo = true;
            }
            else
            {
                ComplainAboutWeather();
            }
        }
        void ThinkAboutPrecipitation()
        {
            if (weather.precipitation != dislikedPrecipitation)
            {
                decisionToGo = true;
            }
            else
            {
                ComplainAboutWeather();
            }

        }
    }
}
