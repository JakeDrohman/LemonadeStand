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
        public int lemonsCount;
        public int cupsOfSugarCount;
        public int iceCubesCount;
        public int cupsCount;
        List<Lemon> lemons = new List<Lemon>();
        List<Sugar> sugar = new List<Sugar>();
        List<Ice_Cube> iceCubes = new List<Ice_Cube>();
        List<Cup> cups = new List<Cup>();
        public Inventory()
        {
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
        public void removeLemons(int numberToRemove)
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
        public void removeSugar(int numberToRemove)
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
    }
}
