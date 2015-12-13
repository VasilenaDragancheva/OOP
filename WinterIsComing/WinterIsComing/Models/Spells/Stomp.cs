using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
   public class Stomp:Spell

    {
        private const int energyCostDefault = 10;
        public Stomp(int damage):base(damage,energyCostDefault)
        {

        }
    }
}
