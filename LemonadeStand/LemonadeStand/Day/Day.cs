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
        Random random = new Random();
        public int glassesLeft;
        Pitcher pitcher = new Pitcher();

        public void calculateCustomersToday()
        {
            customersToday = random.Next(60, 121);
        }
        public void makePitcher(Player player)
        {
            if(player.playerInventory.lemonsCount >= player.recipeLemons && player.playerInventory.cupsOfSugarCount >= player.recipeSugar)
            {
                player.playerInventory.removeLemons(player.recipeLemons);
                player.playerInventory.removeSugar(player.recipeSugar);
                pitcher.refill();
            }
            else
            {
                Console.WriteLine("Insufficient Ingredients, Missed Sale!");
            }
        }
        public void runDay(Player player,Enviornment enviornment)
        {
            makePitcher(player);
            calculateCustomersToday();
            for(int i = customersToday; i > 0; i--)
            {
                Customer customer = new Customer();
                customer.calculateWillingnessToPay(enviornment);
                bool buy = customer.checkIfBuy(player);
                buyglass(player, buy);
                
            }

        }
        public void buyglass(Player player,bool buy)
        {
            if (buy == true && glassesLeft > 0 && player.playerInventory.cupsCount >= 1 && player.playerInventory.iceCubesCount >= player.recipeIce)
            {
                player.playerInventory.removeIce(player.recipeIce);
                player.playerInventory.removeCups(1);
                player.playerInventory.addCash(player.glassPrice);
            }
            else if(buy == true && glassesLeft > 0 && player.playerInventory.cupsCount >= 1 && player.playerInventory.iceCubesCount >= player.recipeIce)
            {
                makePitcher(player);
                buyglass(player, buy);
            }
        }
    }
}
