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
        bool bought;
        //willingness to pay is the very most that someone could charge for a product and they will still pay for it.
        public Customer()
        {
            random = new Random();

        }
        public void CalculateWillingnessToPay(Weather weather, Random random)
        {
            CalculateBaseWillingnessToPay(weather);
            randomInteger = (random.Next(1, 51));
            willingnessToPay = (baseWillingnessToPay - (weather.weather * weathermultiplier) + (randomInteger*0.01m));
        }
        public void CalculateBaseWillingnessToPay(Weather enviornment)
        {
            if (enviornment.temperature > 90)
            {
                baseWillingnessToPay = 0.50m;
            }
            else if (enviornment.temperature >= 80 && enviornment.temperature <= 89)
            {
                baseWillingnessToPay = 0.45m;
            }
            else if (enviornment.temperature >= 70 && enviornment.temperature <= 79)
            {
                baseWillingnessToPay = 0.40m;
            }
            else if (enviornment.temperature >= 60 && enviornment.temperature <= 69)
            {
                baseWillingnessToPay = 0.30m;
            }
            else if (enviornment.temperature < 60)
            {
                baseWillingnessToPay = 0.15m;
            }
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
