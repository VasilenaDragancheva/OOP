using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Spells
{
    public abstract class Spell:ISpell

    {
        protected Spell(int damage,int energycost)
        {
            this.Damage = damage;
            this.EnergyCost = energycost;
        }
        public int Damage
        {
            get;
            private set;
        }

        public int EnergyCost
        {
            get;
            private set;
        }
    }
}
