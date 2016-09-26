using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public int customersToday;
        Random random;
        public List<Customer> customers;
        public Day(Random random)
        {
            this.random = random;
            customers = new List<Customer>();
        }
        public void calculateCustomersToday()
        {
            customersToday = random.Next(60, 121);
        }
        public void RunDay(Player player,Weather weather)
        {
            player.playerInventory.FillPitcher(player);
            calculateCustomersToday();
            for(int i = customersToday; i > 0; i--)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                customer.CalculateWillingnessToPay(weather,random,player);
                bool buy = customer.CheckIfBuy(player);
                SellGlass(player, buy,customer);
                
            }
            Console.WriteLine("You sold {0} glasses of lemonade today to a potential {1} customers"+
                ".",player.playerInventory.glassesSold,customersToday);
            player.playerInventory.glassesSold = 0;
            Console.ReadKey();

        }
        public void SellGlass(Player player,bool buy,Customer customer)
        {
            if(buy == true)
            {
                player.playerInventory.SellLemonade(player);
                customer.AddLemonade();

            }
        }
        public void RunDayVSComputer(Player player, Player computer,Weather weather)
        {
            computer.AddPerDayResources();
            if (computer.playerInventory.cash < 10.96m)
            {
                Console.WriteLine("You Win!");
                Environment.Exit(0);
            }
            player.playerInventory.FillPitcher(player);
            computer.playerInventory.FillPitcher(computer);
            calculateCustomersToday();
            for (int i = customersToday; i > 0; i--)
            {
                computer.SetComputerPrice(random);
                Customer customer = new Customer();
                customers.Add(customer);
                customer.CalculatePreferenceVariable(player, random, weather);
                customer.CalculateWillingnessToPay(weather, random, player);
                decimal playerWTP = customer.willingnessToPay;
                customer.CalculatePreferenceVariable(computer, random, weather);
                customer.CalculateWillingnessToPay(weather, random, computer);
                decimal computerWTP = customer.willingnessToPay;
                if(playerWTP >= computerWTP)
                {
                    bool buy = customer.CheckIfBuy(player);
                    SellGlass(player, buy, customer);
                }
                else if(computerWTP > playerWTP)
                {
                    bool buy = customer.CheckIfBuy(computer);
                    SellGlass(computer, buy, customer);
                }
            }
            Console.WriteLine("You sold {0} glasses of lemonade today to a potential {1} customers" +
                ".", player.playerInventory.glassesSold, customersToday);
            player.playerInventory.glassesSold = 0;
            Console.ReadKey();
        }
    }
}
