﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Mage: Hero
    {
        public Mage(int attack, int defense, int health, int damage, int gold, int experience) : base(attack, defense, health, damage, gold, experience) 
        {
        }
    }
}