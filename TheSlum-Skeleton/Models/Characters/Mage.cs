using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Models.Characters
    
{
    public class Mage : AttackingBaseCharacter
    {
        private const int MageHealthPoints = 150;
        private const int MageDefensePoints = 50;
        private const int MageAttackPoints = 300;
        private const int MageRange = 5;
       

        public Mage(string id,int x,int y,Team team)
            :base(id,x,y,MageHealthPoints,MageDefensePoints,team,MageRange)
        {
            this.AttackPoints = MageAttackPoints;
        }
       
        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList.LastOrDefault(targ => targ.IsAlive == true && this.Team != targ.Team);         
            return target;
        }
    }
}
