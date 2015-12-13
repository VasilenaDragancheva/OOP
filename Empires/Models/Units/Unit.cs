using System;
using Empires.Models.Interfaces;

namespace Empires.Models.Units
{
    public abstract class Unit:IUnit
    {
        private int health;
        private int attackDamage;
        private bool creation = true;
       

        protected Unit(int health,int attackDamage)
        {
            this.Health = health;
            this.AttackDamage = attackDamage;
        }
        public int Health
        {
            get { return this.health; }
            set
            {
                if (creation && value <= 0)
                {
                    throw  new ArgumentOutOfRangeException();
                }
                if (!creation && value < 0)
                {
                    throw  new ArgumentOutOfRangeException();
                }
                this.health = value;
                this.creation = false;
            }
        }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            private set
            {

                if (value < 0)
                {
                    throw  new ArgumentOutOfRangeException();
                }
                this.attackDamage = value;
            }
        }
    }
}
