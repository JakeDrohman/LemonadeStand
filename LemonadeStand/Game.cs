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
        int customersSoldTo;
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
            Console.WriteLine("Would you like to play against the computer?");
            string twoPlayers = Console.ReadLine();
            if (twoPlayers == "no")
            {
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
                foreach (Customer customer in customerList)
                {
                    if (customer.bought == true)
                    {
                        customersSoldTo++;
                    }
                }
                Console.WriteLine("You made {0} over 7 days and sold lemonade to {1} out of {2}" +
                    " customers", (player.playerInventory.cash - 20m), customersSoldTo, totalCustomers);
                Console.ReadLine();
            }
            else if(twoPlayers == "yes")
            {
                Console.WriteLine("Please enter a name for the Computer player.");
                Player computer = new Player(Console.ReadLine());
                Console.Clear();
                for (int i = 1; i <= 7; i++)
                {
                    Console.WriteLine("Day {0}", i);
                    shop.Runshop(player.playerInventory, weather);
                    player.SetRecipe();
                    player.SetPrice();
                    Day day = new Day(random);
                    day.RunDayVSComputer(player,computer, weather);
                    customerList.AddRange(day.customers);
                    Console.Clear();
                }
                Console.WriteLine("You made {0} over 7 days", (player.playerInventory.cash - 20m));
                Console.WriteLine("{1} made {0} over 7 days", (computer.playerInventory.cash - 20m), computer.name);
                Console.ReadLine();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                rungame();

            }
            
        }
    }
}
