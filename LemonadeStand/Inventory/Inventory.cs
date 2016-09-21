using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public decimal cash;
        public int glassesSold;
        public int lemonsCount;
        public int cupsOfSugarCount;
        public int iceCubesCount;
        public int cupsCount;
        public int lemonadeCount;
        Pitcher pitcher;
        List<Lemon> lemons;
        List<Sugar> sugar;
        List<Ice_Cube> iceCubes;
        List<Cup> cups;
        List<Lemonade> glassesOfLemonade;
        public Inventory()
        {
            this.pitcher = new Pitcher();
            this.lemons = new List<Lemon>();
            this.sugar = new List<Sugar>();
            this.iceCubes = new List<Ice_Cube>();
            this.cups = new List<Cup>();
            this.glassesOfLemonade = new List<Lemonade>();
            cash =20.00m;
        }

        public void addLemons(int numberOfLemons)
        {
            for(int i = 1; i <=numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            lemonsCount = lemons.Count;
        }
        public void RemoveLemons(int numberToRemove)
        {
            for (int i = 1; i <= numberToRemove; i++)
            {
                    lemons.RemoveAt(0);
            }
            lemonsCount = lemons.Count;
        }
        public void addSugar(int numberOfCups)
        {
            for(int i = 1; i <= numberOfCups; i++)
            {
                Sugar cup = new Sugar();
                sugar.Add(cup);
            }
            cupsOfSugarCount = sugar.Count;
        }
        public void RemoveSugar(int numberToRemove)
        {
            for (int i = 1; i <= numberToRemove; i++)
            {
                sugar.RemoveAt(0);
            }
            cupsOfSugarCount = sugar.Count;
        }
        public void addIce(int cubes)
        {
            for(int i = 1; i <= cubes; i++)
            {
                Ice_Cube ice = new Ice_Cube();
                iceCubes.Add(ice);
            }
            iceCubesCount = iceCubes.Count;
        }
        public void removeIce(int numberToRemove)
        {
            for (int i = 1; i <= numberToRemove; i++)
            {
                iceCubes.RemoveAt(0);
            }
            iceCubesCount = iceCubes.Count;
        }
        public void addCups(int numberOfCups)
        {
            for(int i = 1; i <= numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
            cupsCount = cups.Count;
        }
        public void removeCups(int numberToRemove)
        {
            for(int i = 1; i <= numberToRemove; i++)
            {
                cups.RemoveAt(0);
            }
            cupsCount = cups.Count;
        }
        public void addCash(decimal revenue)
        {
            cash += revenue;
        }
        public void removeCash(decimal subtraction)
        {
            cash -= subtraction;
        }
        public void displayInventory()
        {
            Console.WriteLine("Inventory:{0}Cash: ${1}{0}Lemons: {2}{0}Cups of Sugar: {3}{0}Ice Cubes: {4}{0}Cups:{5}", Environment.NewLine,cash,lemonsCount
                ,cupsOfSugarCount,iceCubesCount,cupsCount);
        }
        public void FillPitcher(Player player)
        {
            if(lemonsCount >= player.recipeLemons && cupsOfSugarCount >= player.recipeSugar)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Lemonade lemonade = new Lemonade();
                    glassesOfLemonade.Add(lemonade);
                }
                RemoveLemons(player.recipeLemons);
                RemoveSugar(player.recipeSugar);
                lemonadeCount = glassesOfLemonade.Count;
            }
        }
        public void SellLemonade(Player player)
        {
            if (lemonadeCount > 0 && lemonsCount >= player.recipeLemons && cupsOfSugarCount >= player.recipeSugar &&
                iceCubesCount >= player.recipeIce && cupsCount > 0)
            {
                glassesOfLemonade.RemoveAt(0);
                lemonadeCount = glassesOfLemonade.Count;
                addCash(player.glassPrice);
                glassesSold++;
                removeIce(player.recipeIce);
                removeCups(1);
            }
            else if(lemonadeCount == 0 && lemonsCount >= player.recipeLemons && cupsOfSugarCount >= player.recipeSugar &&
                iceCubesCount >= player.recipeIce && cupsCount > 0)
            {
                FillPitcher(player);
                SellLemonade(player);
            }
            else
            {
                Console.WriteLine("Insufficient Ingredients, Missed Sales!");
            }
        }
    }
}
