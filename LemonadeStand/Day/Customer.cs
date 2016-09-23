using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public decimal willingnessToPay;
        decimal weathermultiplier = 0.05m;
        decimal baseWillingnessToPay = 0.5m;
        Random random;
        int randomInteger;
        public bool bought;
        int optimalLemons;
        decimal optimalIce;
        decimal optimalIceVariable;
        int optimalSugar;
        int preferenceBoost;
        decimal preferenceBoostVariable;
        //willingness to pay is the very most that someone could charge for a product and they will still pay for it.
        public Customer()
        {
            random = new Random();
            optimalLemons = 6;
            optimalSugar = 4;

        }
        public void CalculateWillingnessToPay(Weather weather, Random random,Player player)
        {
            CalculateBaseWillingnessToPay(weather);
            CalculatePreferenceVariable(player, random, weather);
            randomInteger = (random.Next(1, 31));
            willingnessToPay = (baseWillingnessToPay - (weather.weather * weathermultiplier) + (randomInteger*0.01m) + preferenceBoostVariable);
        }
        public void CalculateBaseWillingnessToPay(Weather weather)
        {
            if (weather.temperature > 90)
            {
                baseWillingnessToPay = 0.50m;
            }
            else if (weather.temperature >= 80 && weather.temperature <= 89)
            {
                baseWillingnessToPay = 0.45m;
            }
            else if (weather.temperature >= 70 && weather.temperature <= 79)
            {
                baseWillingnessToPay = 0.40m;
            }
            else if (weather.temperature >= 60 && weather.temperature <= 69)
            {
                baseWillingnessToPay = 0.30m;
            }
            else if (weather.temperature < 60)
            {
                baseWillingnessToPay = 0.15m;
            }
        }
        public void CalculatePreferenceVariable(Player player,Random random,Weather weather)
        {
            CalculateOptimalIce(weather);
            int tasteRange = random.Next(1, 5);
            if (player.recipeLemons >= optimalLemons - tasteRange && player.recipeLemons <= optimalLemons + tasteRange)
            { AddToPreferenceBoost(5); }
            if (player.recipeSugar >= optimalSugar - tasteRange && player.recipeSugar <= optimalSugar + tasteRange)
            { AddToPreferenceBoost(5); }
            if (player.recipeIce >= optimalIce - tasteRange && player.recipeIce <= optimalIce + tasteRange)
            { AddToPreferenceBoost(5); }
            decimal temporaryValue = (Convert.ToDecimal(preferenceBoost)) * .01m;
            temporaryValue = preferenceBoostVariable;
        }
        public void AddToPreferenceBoost(int addedNumber)
        {
            for (int i = 1; i <= addedNumber; i++)
            {
                preferenceBoost++;
            }
        }
        public void CalculateOptimalIce(Weather weather)
        {
            optimalIceVariable = Convert.ToDecimal(weather.temperature)*.1m - 5;
            optimalIce =Convert.ToInt32(optimalIceVariable);
        }
        public bool CheckIfBuy(Player player)
        {
            if(player.glassPrice <= willingnessToPay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddLemonade()
        {
            Lemonade tastyLemonade = new Lemonade();
            bought = true;
        }
    }
}
