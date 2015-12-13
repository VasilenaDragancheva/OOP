using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Models.Characters
{
    public abstract class AttackingBaseCharacter : BaseCharacter, IAttack
    {
        protected AttackingBaseCharacter(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {

        }


        public int AttackPoints { get; set; }
        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }
        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }
        public override string ToString()
        {
            return string.Format("{0}, Attack: {1}", base.ToString(), this.AttackPoints);
        }

    }
}
