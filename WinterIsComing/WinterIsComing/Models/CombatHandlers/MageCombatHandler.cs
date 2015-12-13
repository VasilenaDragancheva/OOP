using System;
using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Core;
using WinterIsComing.Contracts;
using WinterIsComing.Models.Spells;
using WinterIsComing.Core.Exceptions;


namespace WinterIsComing.Models.CombatHandlers
{
    class MageCombatHandler:CombatHandler
    {
        private int counter;
        public MageCombatHandler():base()
        {
            this.counter = 1;
        }
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderByDescending(targ => targ.HealthPoints).ThenBy(targ => targ.Name).Take(3);
            return targets;
        }

        public override  ISpell GenerateAttack()
        {
            ISpell attack;
            if(counter%2==1)
            {
                attack = new FireBreath(this.Unit.AttackPoints);
            }
            else
            {
                attack = new Blizzard(this.Unit.AttackPoints * 2);
            }
            if (this.Unit.EnergyPoints < attack.EnergyCost)
            {
                throw new NotEnoughEnergyException(
                    string.Format(string.Format("{0}",GlobalMessages.NotEnoughEnergy)
                    , this.Unit.Name, 
                    attack.GetType().Name));
            }
            this.counter++;
            this.Unit.EnergyPoints -= attack.EnergyCost;
            return attack;

        }
    }
}
