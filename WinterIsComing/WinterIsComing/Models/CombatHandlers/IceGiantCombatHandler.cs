using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class IceGiantCombatHandler:CombatHandler
    {
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (this.Unit.HealthPoints <= 150)
            {
                return candidateTargets.Take(1);
            }
            return candidateTargets;
        }

        public override Contracts.ISpell GenerateAttack()
        {
            ISpell spell = new Stomp(this.Unit.AttackPoints);
            if (spell.EnergyCost >this.Unit.EnergyPoints)
            {
                throw new NotEnoughEnergyException(
                  string.Format(string.Format("{0}", GlobalMessages.NotEnoughEnergy)
                  , this.Unit.Name,
                  spell.GetType().Name));
            }

            this.Unit.EnergyPoints -= spell.EnergyCost;
            this.Unit.AttackPoints += 5;
            return spell;
            
        }
    }
}
