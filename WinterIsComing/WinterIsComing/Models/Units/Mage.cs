using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class Mage : Unit
    {
        private const int rangeDefault = 2;
        private const int attackPointsDefault = 80;
        private const int healthPointsDefault = 80;
        private const int defensePointsDefault = 40;
        private const int energyPointsDefault = 120;
        public Mage(int x, int y, string name)
            : base(x, y, name, rangeDefault, attackPointsDefault, healthPointsDefault, defensePointsDefault,
                energyPointsDefault, new MageCombatHandler())
        {

        }
    }
}
