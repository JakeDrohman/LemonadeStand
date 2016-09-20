using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Shop
    {
        public void runshop(Inventory inventory,Enviornment enviornment)
        {
            enviornment.decideTemperature();
            enviornment.decideWeather();
            enviornment.showWeather();
            displayShopHome(inventory);

        }
        public void displayShopHome(Inventory inventory)
        {
            inventory.displayInventory();
            Console.WriteLine("-----Shop-----");
            Console.WriteLine("Type an ingredient or type done and press enter.");
            Console.WriteLine("lemons {0}sugar {0}ice {0}cups {0}{0}done",Environment.NewLine);
            string input = Console.ReadLine();
            switch (input)
            {
                case ("cups"):
                    displayCups(inventory);
                    break;
                case ("lemons"):
                    displayLemons(inventory);
                    break;
                case ("sugar"):
                    displaySugar(inventory);
                    break;
                case ("ice"):
                    displayIce(inventory);
                    break;
                case ("done"):
                    break;
                default:
                    Console.WriteLine("Please enter a valid input(all lowercase)");
                    displayShopHome(inventory);
                    break;
            }
        }
        public void displayCups(Inventory inventory)
        {
            inventory.displayInventory();
            Console.WriteLine("Enter the amount you would like to buy {0}Cups: {0}25 for  $0.95{0}50  for $1.49{0}"+
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
                    displayCups(inventory);
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
                    displayCups(inventory);
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
                    displayCups(inventory);
                    break;
                case ("go back"):
                    displayShopHome(inventory);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    displayCups(inventory);
                    break;
            }
        }
        public void displayLemons(Inventory inventory)
        {
            inventory.displayInventory();
            Console.WriteLine("Enter the amount you would like to buy {0}Lemons: {0}10 for  $0.99{0}25  for $1.99{0}" +
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
                    displayLemons(inventory);
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
                    displayLemons(inventory);
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
                    displayLemons(inventory);
                    break;
                case ("go back"):
                    displayShopHome(inventory);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    displayLemons(inventory);
                    break;
            }
        }
        public void displaySugar(Inventory inventory)
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
                    displaySugar(inventory);
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
                    displaySugar(inventory);
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
                    displaySugar(inventory);
                    break;
                case ("go back"):
                    displayShopHome(inventory);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    displaySugar(inventory);
                    break;
            }
        }
        public void displayIce(Inventory inventory)
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
                    displayIce(inventory);
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
                    displayIce(inventory);
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
                    displayIce(inventory);
                    break;
                case ("go back"):
                    displayShopHome(inventory);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    displayIce(inventory);
                    break;
            }
        }
    }
}
