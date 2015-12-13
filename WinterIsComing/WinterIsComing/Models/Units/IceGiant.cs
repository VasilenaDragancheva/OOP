using System;
using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Contracts;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
   public class IceGiant:Unit
    {
        private const int rangeDefault = 1;
        private const int attackPointsDefault = 150;
        private const int healthPointsDefault =300;
        private const int defensePointsDefault = 60;
        private const int energyPointsDefault = 50;
        public IceGiant(int x, int y, string name)
            : base(x, y, name, rangeDefault, attackPointsDefault, healthPointsDefault, defensePointsDefault,
                energyPointsDefault, new IceGiantCombatHandler())
        {

        }
    }
}
