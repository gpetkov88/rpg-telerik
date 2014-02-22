using System;
using System.Linq;

namespace Interface
{
    public class Amazon: Hero
    {
        public Amazon(int attack, int defense, int health, int damage, int gold, int experience) : base(attack, defense, health, damage, gold, experience) 
        {
        }
    }
}
