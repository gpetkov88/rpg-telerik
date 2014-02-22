using System;
using System.Linq;

namespace Interface
{
    public class Archer: Hero
    {
        public Archer(int attack, int defense, int health, int damage, int gold, int experience) : base(attack, defense, health, damage, gold, experience) 
        {
        }
    }
}
