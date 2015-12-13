using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
   public class Warrior:Unit
    {
        private const int rangeDefault=1;
        private const int attackPointsDefault=120;
        private const int healthPointsDefault=180;
        private const int defensePointsDefault=70;
        private const int energyPointsDefault = 60;
       
        public Warrior(int x, int y, string name)
            :base(x,y,name,rangeDefault,attackPointsDefault,healthPointsDefault,defensePointsDefault,energyPointsDefault,new WarriorCombatHandler())
        {

        }
      
    }
}
