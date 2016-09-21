using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        int customersToday;
        int totalCustomers;
        Random random;
        List<Customer> customers;
        public Day(Random random)
        {
            this.random = random;
            customers = new List<Customer>();
        }
        public void calculateCustomersToday()
        {
            customersToday = random.Next(60, 121);
        }
        public void runDay(Player player,Weather weather)
        {
            player.playerInventory.FillPitcher(player);
            calculateCustomersToday();
            for(int i = customersToday; i > 0; i--)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                customer.CalculateWillingnessToPay(weather,random);
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
    }
}
