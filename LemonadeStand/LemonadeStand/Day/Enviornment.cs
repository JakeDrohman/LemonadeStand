using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Enviornment
    {
        public int temperature;
        public int weather;
        //0 = sunny
        //1 = mostly sunny
        //2 = mostly cloudy
        //3 = rain
        List<string> weatherTypes = new List<string> {"Sunny","Mostly Sunny","Mostly Cloudy","Rainy"};
        Random random = new Random();
        char degrees = (char)176;
        public void decideWeather()
        {
            weather = random.Next(0, 4);
        }
        public void decideTemperature()
        {
            temperature = random.Next(55, 101);
        }
        public void showWeather()
        {
            Console.WriteLine("Today it will be {0} and {1}{2}", weatherTypes.ElementAt(weather), temperature, degrees);
        }
    }
}
