using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Vampire: NPC
    {
        //Constructor
         public Vampire(int attack, int defence, int health, int damage) : base(attack, defence, health, damage) 
        { 
        }
    }
}
