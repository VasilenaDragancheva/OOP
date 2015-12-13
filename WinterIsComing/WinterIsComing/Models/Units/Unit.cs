using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Core;
using WinterIsComing.Contracts;
using WinterIsComing.Core.Exceptions;

namespace WinterIsComing.Models.Units
{
    public abstract class Unit : IUnit
    {

        private int x;
        private int y;
        private string name;
        private int range;
        private int attackPoints;
        private int healthPoints;
        private int defensePoints;
        private int energyPoints;
        protected Unit(int x, int y, string name, int range, int attackPoints, int healthPoints, int defensePoints, int energyPoints, ICombatHandler combatHandler)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Range = range;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.EnergyPoints = energyPoints;
            this.CombatHandler = combatHandler;
            this.CombatHandler.Unit = this;
        }


        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new InvalidPositionException(GlobalMessages.InvalidPosition);
                }
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new InvalidPositionException(GlobalMessages.InvalidPosition);
                }
                this.y = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new GameException("Inavlid name");
                }
                this.name = value;
            }
        }

        public int Range
        {
            get { return this.range; }
            private set { this.range = value; }
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            set
            {
                this.defensePoints = value;
            }
        }

        public int EnergyPoints
        {
            get
            {
                return this.energyPoints;
            }
            set
            {
                this.energyPoints = value;
            }
        }

        public ICombatHandler CombatHandler { get; set; }
        public override string ToString()
        {
            if (healthPoints > 0)
            {
                StringBuilder result=new StringBuilder();
                result.AppendFormat(">{0} - {1} at ({2},{3}){4}", this.Name, this.GetType().Name, this.X, this.Y, Environment.NewLine);
                 result.AppendFormat("-Health points = {0}{1}",this.HealthPoints, Environment.NewLine);
                result.AppendFormat("-Attack points = {0}{1}",this.AttackPoints, Environment.NewLine);
                result.AppendFormat("-Defense points = {0}{1}",this.DefensePoints, Environment.NewLine);
                result.AppendFormat("-Energy points = {0}{1}",this.EnergyPoints, Environment.NewLine);
                result.AppendFormat("-Range = {0}",this.Range);
                return result.ToString();
            }
            else
            {
                return string.Format(">{0} - {1} at ({2},{3}){4}(Dead)", this.Name, this.GetType().Name, this.X, this.Y, Environment.NewLine);
            }
        }

    }
}
