using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Models.Characters
{
    public class Healer : BaseCharacter, IHeal
    {
        private const int HealerHealthPoints = 75;
        private const int HealerDefensePoints = 50;
        private const int HealerHealingPoints = 60;
        private const int HealerRange = 6;
      
        public Healer(string id, int x, int y,Team team)
            : base(id,x,y,HealerHealthPoints,HealerDefensePoints,team,HealerRange)
        {
            this.HealingPoints = HealerHealingPoints;
        }


        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList.OrderBy(targ => targ.HealthPoints).FirstOrDefault(charact => (charact != this&&charact.Team==this.Team));
            
            return target;
        }
        public override string ToString()
        {
            return base.ToString() + " Healing: " + this.HealingPoints;
        }
     

     
    }
}
