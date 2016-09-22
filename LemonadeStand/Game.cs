using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        int totalCustomers;
        Weather weather;
        Shop shop;
        Random random;
        List<Customer> customerList;
        public Game()
        {
            random = new Random();
            weather = new Weather();
            shop = new Shop();
            customerList = new List<Customer>();
        }
        public void rungame()
        {
            Console.WriteLine("Please enter a name for your player");
            Player player = new Player(Console.ReadLine());
            Console.WriteLine("Here's 20 bucks, make a lemonade stand. Good luck");
            Console.ReadKey();
            Console.Clear();
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Day {0}", i);
                shop.Runshop(player.playerInventory, weather);
                player.SetRecipe();
                player.SetPrice();
                Day day = new Day(random);
                day.RunDay(player, weather);
                customerList.AddRange(day.customers);
                Console.Clear();
            }
            totalCustomers = customerList.Count;

            Console.WriteLine("You made {0} over 7 days and sold lemonade to {1} out of {2} customers",(player.playerInventory.cash-20m), ,totalCustomers);
            Console.ReadLine();
        }
    }
}
