﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Mage: Hero
    {
        public Mage(int attack, int defence, int health, int damage, int gold, int experiance) : base(attack, defence, health, damage, gold, experiance) 
        {
        }
    }
}
