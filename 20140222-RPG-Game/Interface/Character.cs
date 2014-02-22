using System;
using System.Linq;

namespace Interface
{
    public abstract class Character
    {
        //Field
        protected int attack;
        protected int defense;
        protected int health;
        protected int damage;
        //Property
        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }
        public int Defense
        {
            get { return this.defense; }
            set { this.defense = value; }
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
        public Character (int attack, int defense, int health, int damage)
        {
            this.Attack = attack;
            this.defense = defense;
            this.Health = health;
            this.Damage = damage;
        }
        //Methods
        public abstract void  SomeMethod();
    }
}
