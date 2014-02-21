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
        private int experiance;
        //Properties
        public int Gold
        {
            get { return this.gold; }
            set { this.gold = value; }
        }
        public int Experiance
        {
            get { return this.experiance; }
            set { this.experiance = value; }
        }
        //Constructor
        public Hero(int attack, int defence, int health, int damage, int gold, int experiance) : base(attack, defence, health, damage) 
        {
            this.Gold = gold;
            this.Experiance = experiance;
        }
        //Methods
        public void GainGold()
        { 
        }
        public void GainExpererianc()
        { 
        }
        public override void SomeMethod()
        {
        }
    }
}
