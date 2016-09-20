using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int temperature;
        public int weather;
        //0 = sunny
        //1 = mostly sunny
        //2 = mostly cloudy
        //3 = rain
        Random random;
        List<string> weatherTypes;
        char degrees = (char)176;
        public Weather()
        {
            this.weatherTypes = new List<string> { "Sunny", "Mostly Sunny", "Mostly Cloudy", "Rainy" };
            this.random = new Random();
        }
        public void DecideWeather()
        {
            weather = random.Next(0, 4);
        }
        public void DecideTemperature()
        {
            temperature = random.Next(55, 101);
        }
        public void ShowWeather()
        {
            Console.WriteLine("Today it will be {0} and {1}{2}", weatherTypes.ElementAt(weather), temperature, degrees);
        }
    }
}
