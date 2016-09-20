using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public Inventory playerInventory = new Inventory();
        public int recipeLemons;
        public int recipeSugar;
        public int recipeIce;
        public decimal glassPrice;

        public Player(string name)
        {
            this.name = name;
        }
        public void SetRecipe()
        {
            SetLemonRecipe();
            SetSugarRecipe();
            SetIceRecipe();
        }
        public void SetLemonRecipe()
        {
            try
            {
                Console.WriteLine("How many lemons would you like in each pitcher?");
                recipeLemons = Convert.ToInt32(Console.ReadLine());
                if (recipeLemons <= 0)
                {
                    Console.WriteLine("Please enter a positive integer");
                    SetLemonRecipe();
                }
            }
            catch
            {
                Console.WriteLine("Please enter a positive integer");
                SetLemonRecipe();
            }
        }
        public void SetSugarRecipe()
        {
            try
            {
                Console.WriteLine("How many cups of sugar would you like in each pitcher?");
                recipeSugar = Convert.ToInt32(Console.ReadLine());
                if (recipeSugar <= 0)
                {
                    Console.WriteLine("Please enter a positive integer");
                    SetSugarRecipe();
                }
            }
            catch
            {
                Console.WriteLine("Please enter a positive integer");
                SetSugarRecipe();
            }
        }
        public void SetIceRecipe()
        {
            try
            {
                Console.WriteLine("How many ice cubes would you like in each glass?");
                recipeIce = Convert.ToInt32(Console.ReadLine());
                if (recipeIce <= 0)
                {
                    Console.WriteLine("Please enter a positive integer");
                    SetIceRecipe();
                }
            }
            catch
            {
                Console.WriteLine("Please enter a positive integer");
                SetIceRecipe();
            }
        }
        public void SetPrice()
        {
            try
            {
                Console.WriteLine("How much would you like to set for the price per glass?");
                glassPrice = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a positive decimal.(hint: between 0 and 0.75)");
                SetPrice();
            }
        }
    }
}
