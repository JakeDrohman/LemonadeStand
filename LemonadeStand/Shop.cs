using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Shop
    {
        public void Runshop(Inventory inventory,Weather weather)
        {
            weather.DecideTemperature();
            weather.DecideWeather();
            weather.ShowWeather();
            DisplayShopHome(inventory, weather);

        }
        public void DisplayShopHome(Inventory inventory,Weather weather)
        {
            weather.ShowWeather();
            inventory.displayInventory();
            Console.WriteLine("{0}{0}-----Shop-----",Environment.NewLine);
            Console.WriteLine("Type an ingredient or type done and press enter. Make note of the weather located at the top"+
                " right, it WILL affect sales");
            Console.WriteLine("lemons {0}sugar {0}ice {0}cups {0}{0}done",Environment.NewLine);
            string input = Console.ReadLine();
            switch (input)
            {
                case ("cups"):
                    Console.Clear();
                    DisplayCups(inventory,weather);
                    break;
                case ("lemons"):
                    Console.Clear();
                    DisplayLemons(inventory,weather);
                    break;
                case ("sugar"):
                    Console.Clear();
                    DisplaySugar(inventory, weather);
                    break;
                case ("ice"):
                    Console.Clear();
                    DisplayIce(inventory, weather);
                    break;
                case ("weather"):
                    Console.Clear();
                    weather.ShowWeather();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("done"):
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input(all lowercase)");
                    DisplayShopHome(inventory,weather);
                    break;
            }
        }
        public void DisplayCups(Inventory inventory,Weather weather)
        {
            
            inventory.displayInventory();
            Console.WriteLine("{0}{0}Enter the amount you would like to buy {0}Cups: {0}25 for  $0.95{0}50  for $1.49{0}"+
                "100 for $2.49{0}go back", Environment.NewLine);
            string buyinput = Console.ReadLine();
            switch (buyinput)
            {
                case ("25"):
                    if(inventory.cash >= 0.95m)
                    {
                        inventory.addCups(25);
                        inventory.removeCash(0.95m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("50"):
                    if (inventory.cash >= 1.49m)
                    {
                        inventory.addCups(50);
                        inventory.removeCash(1.49m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("100"):
                    if (inventory.cash >= 2.49m)
                    {
                        inventory.addCups(100);
                        inventory.removeCash(2.49m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("go back"):
                    DisplayShopHome(inventory, weather);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    Console.ReadKey();
                    Console.Clear();
                    DisplayCups(inventory, weather);
                    break;
            }
        }
        public void DisplayLemons(Inventory inventory,Weather weather)
        {
            inventory.displayInventory();
            Console.WriteLine("Enter the amount you would like to buy {0}Lemons: {0}10  for $0.99{0}25  for $1.99{0}" +
                "75  for $4.49{0}go back", Environment.NewLine);
            string buyinput = Console.ReadLine();
            switch (buyinput)
            {
                case ("10"):
                    if (inventory.cash >= 0.99m)
                    {
                        inventory.addLemons(10);
                        inventory.removeCash(0.99m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("25"):
                    if (inventory.cash >= 1.99m)
                    {
                        inventory.addLemons(25);
                        inventory.removeCash(1.99m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("75"):
                    if (inventory.cash >= 4.49m)
                    {
                        inventory.addLemons(75);
                        inventory.removeCash(4.49m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("go back"):
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    DisplayLemons(inventory, weather);
                    break;
            }
        }
        public void DisplaySugar(Inventory inventory,Weather weather)
        {
            inventory.displayInventory();
            Console.WriteLine("Enter the amount you would like to buy {0}Sugar: {0}8  for  $0.79{0}20  for $1.49{0}" +
                "48  for $2.99{0}go back", Environment.NewLine);
            string buyinput = Console.ReadLine();
            switch (buyinput)
            {
                case ("8"):
                    if (inventory.cash >= 0.79m)
                    {
                        inventory.addSugar(8);
                        inventory.removeCash(0.79m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("20"):
                    if (inventory.cash >= 1.49m)
                    {
                        inventory.addSugar(20);
                        inventory.removeCash(1.49m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("48"):
                    if (inventory.cash >= 2.99m)
                    {
                        inventory.addSugar(48);
                        inventory.removeCash(2.99m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("go back"):
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    DisplaySugar(inventory, weather);
                    break;
            }
        }
        public void DisplayIce(Inventory inventory,Weather weather)
        {
            inventory.displayInventory();
            Console.WriteLine("Enter the amount you would like to buy {0}Ice Cubes: {0}100 for $0.95{0}250 for $1.99{0}" +
                "500 for $2.99{0}go back", Environment.NewLine);
            string buyinput = Console.ReadLine();
            switch (buyinput)
            {
                case ("100"):
                    if (inventory.cash >= 0.95m)
                    {
                        inventory.addIce(100);
                        inventory.removeCash(0.95m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("250"):
                    if (inventory.cash >= 1.99m)
                    {
                        inventory.addIce(250);
                        inventory.removeCash(1.99m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("500"):
                    if (inventory.cash >= 2.99m)
                    {
                        inventory.addIce(500);
                        inventory.removeCash(2.99m);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                case ("go back"):
                    Console.Clear();
                    DisplayShopHome(inventory, weather);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    DisplayIce(inventory, weather);
                    break;
            }
        }
    }
}
