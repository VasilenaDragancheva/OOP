using System;
using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Core;
using WinterIsComing.Contracts;
using WinterIsComing.Models.Spells;
using WinterIsComing.Core.Exceptions;

namespace WinterIsComing.Models.CombatHandlers
{
    class WarriorCombatHandler : CombatHandler
    {
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (this.Unit.HealthPoints >= 50)
            {
                this.Unit.EnergyPoints -= this.GenerateAttack().EnergyCost;
            }
            return candidateTargets.OrderBy(targ => targ.HealthPoints).ThenBy(targ => targ.Name).Take(1);

        }

        public override ISpell GenerateAttack()
        {
            int damage = this.Unit.AttackPoints;
            if (this.Unit.HealthPoints <= 80)
            {
                damage += 2 * this.Unit.HealthPoints;
            }

            ISpell attack = new Cleave(damage);
            if (this.Unit.EnergyPoints < attack.EnergyCost)
            {
                throw new NotEnoughEnergyException(
                    string.Format(string.Format("{0}", GlobalMessages.NotEnoughEnergy)
                    , this.Unit.Name,
                    attack.GetType().Name));
            }
            if (this.Unit.EnergyPoints > 50)
            {
                this.Unit.EnergyPoints -= attack.EnergyCost;
            }

            return attack;
        }
    }
}
