using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        public int glassesLeft;
        private int glassesInPitcher = 10;
        public void refill()
        {
            glassesLeft = glassesInPitcher;
        }
    }
}
