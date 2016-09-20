using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Enviornment enviornment = new Enviornment();
        Shop shop = new Shop();
        public void rungame()
        {
            Console.WriteLine("Please enter a name for your player");
            Player player = new Player(Console.ReadLine());
            Console.WriteLine("Here's 20 bucks, make a lemonade stand. Good luck");
            for(int i = 1; i <= 7; i++)
            {
                shop.runshop(player.playerInventory, enviornment);
                player.setRecipe();
                player.setPrice();
                Day day = new Day();
                day.runDay(player, enviornment);
            }
            Console.WriteLine("You made {0} over 7 days", player.playerInventory.cash);
            Console.ReadLine();
        }
    }
}
