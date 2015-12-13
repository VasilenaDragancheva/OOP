using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Models.Items
{
    public class Pill : Bonus
    {
        private const int PillHealthEffect = 0;
        private const int PillDefenseEffect = 0;
        private const int PillAttackEffect =100;
        private const int PillEffectTurns = 1;
        public Pill(string id)
            : base(id, PillHealthEffect, PillDefenseEffect, PillAttackEffect)
        {
            this.Timeout = PillEffectTurns;
            this.Countdown = PillEffectTurns;
        }
    }
}
