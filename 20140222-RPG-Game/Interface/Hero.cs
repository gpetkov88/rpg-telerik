using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Hero: Character
    {
        //Fields
        private int gold;
        private int experiеnce;
        //Constructor
        public Hero(int attack, int defense, int health, int damage, int gold, int experience) : base(attack, defense, health, damage) 
        {
            this.Gold = gold;
            this.Experience = experience;
        }
        //Methods
        public void GainGold()
        { 
        }
        public void GainExperience()
        {
        }
        public override void SomeMethod()
        {
        }
        //Properties
        public int Gold
        {
            get { return this.gold; }
            set { this.gold = value; }
        }
        public int Experience
        {
            get { return this.experiеnce; }
            set { this.experiеnce = value; }
        }
    }
}