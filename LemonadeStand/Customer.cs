using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public string name;
        protected string dislikedWeatherType;
        protected double dislikedAirTemperature;
        protected double dislikedWindSpeed;
        protected double dislikedPrecipitation;
        protected double favoriteObject1Amount;
        protected double favoriteObject2Amount;
        protected double favoriteObject3Amount;
        protected double favoriteObject4Amount;
        protected double dislikedObject1Amount;
        protected double dislikedObject2Amount;
        protected double dislikedObject3Amount;
        protected double dislikedObject4Amount;
        protected  double maxPay;
        protected bool decisionToBuy;
        protected bool decisionToGo;
        protected Player player;
        protected Weather weather;

        public Customer(Player player, Weather weather, string name, string dislikedWeatherType, double dislikedAirTemperature, double dislikedWindSpeed, double dislikedPrecipitation, double favoriteObject1Amount, double favoriteObject2Amount, double favoriteObject3Amount, double favoriteObject4Amount, double dislikedObject1Amount, double dislikedObject2Amount, double dislikedObject3Amount, double dislikedObject4Amount, double maxPay)
        {
            this.player = player;
            this.weather = weather;
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
            this.maxPay = maxPay;
        }
       
        public void DecideToGo()
        {
            ThinkABoutWeatherType();
            ThinkAboutTemp();
            ThinkAboutWindSpeed();
            ThinkAboutPrecipitation();
            CheckIfDecidedToGo();
        }
        void CheckIfDecidedToGo()
        {
            if (decisionToGo == false)
            {
                DecideNotToBuy();
            }
            else
            {
                player.attendanceList.amountOfAllCustomersToAttend++;
                DecideAboutBuying();
            }
        }
        void DecideAboutBuying()
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
            if ((player.inventory.item1Amount <= player.recipeBook.item1RecipeAmount) || (player.inventory.item2Amount <= player.recipeBook.item2RecipeAmount) || (player.inventory.item3Amount <= player.recipeBook.item3RecipeAmount) || (player.inventory.item4Amount <= player.recipeBook.item4RecipeAmount))
            {
                ComplainAboutNoProducts();
            }
            else
            {
                BuyProduct();
            }
        }
        void BuyProduct()
        {
            DecideOnTaste();
            player.SellProduct();
        }
        void ComplainAboutNoProducts()
        {
            player.reviewBook.complaintsAboutNoDrinks++;
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
    }
}
