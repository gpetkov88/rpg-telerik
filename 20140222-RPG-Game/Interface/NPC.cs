using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class NPC: Character
    {
        //Constructor
         public NPC(int attack, int defense, int health, int damage) : base(attack, defense, health, damage) 
        { 
        }
        //Method
         public override void SomeMethod()
         { 
         }
    }
}
