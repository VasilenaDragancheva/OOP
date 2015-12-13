using System;
using System.Collections.Generic;
using System.Linq;

using TheSlum.Interfaces;

namespace TheSlum.Models.Characters
{
    public class Warrior : AttackingBaseCharacter
    {
        private const int WarriorHealthPoints = 200;
        private const int WarriorDefensePoints = 100;
        private const int WarriorAttackPoints = 150;
        private const int WarriorRange = 2;
        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, WarriorHealthPoints, WarriorDefensePoints, team, WarriorRange)
        {
            this.AttackPoints = WarriorAttackPoints;
        }
     
        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList.FirstOrDefault(charac=>charac.IsAlive==true&&charac.Team!=this.Team);
            return target;
        }
      
       
    }
}
