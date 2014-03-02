using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public abstract class Character
    {
        //Field
        protected int attack;
        protected int defence;
        protected int health;
        protected int damage;
        //Property
        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }
        public int Defence
        {
            get { return this.defence; }
            set { this.defence = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }
        //Constructor
        public Character (int attack, int defence, int health, int damage)
        {
            this.Attack = attack;
            this.Defence = defence;
            this.Health = health;
            this.Damage = damage;
        }
        //Methods
        public abstract void  SomeMethod();
    }
}
