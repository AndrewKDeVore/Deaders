using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Dice
    {
        private static Random rng = new Random();

        public static int Roll(int rolls, int sides)
        {
            int ret = 0;
            for(int i = 0; i < rolls; i++)
            {
                ret += rng.Next(1, sides);
            }
            return ret;
        }
    }
}
