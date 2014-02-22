using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Zombie: NPC
    {
        //Constructor
         public Zombie(int attack, int defense, int health, int damage) : base(attack, defense, health, damage) 
        { 
        }
    }
}
