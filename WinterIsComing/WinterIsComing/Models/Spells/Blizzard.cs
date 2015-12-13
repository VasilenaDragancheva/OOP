using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    public class Blizzard:Spell
    {
        private const int energyCostDefault = 40;
        public Blizzard(int damage):base(damage,energyCostDefault)
        {

        }
    }
}
