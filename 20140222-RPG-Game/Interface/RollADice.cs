using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public static class RollADice
    {
        public static int Roll(int Range)
        {
            return new Random().Next(1, Range+1);
        }
    }
}
