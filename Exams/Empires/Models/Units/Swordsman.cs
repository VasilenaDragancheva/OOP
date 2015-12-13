using Empires.Attributes;

namespace Empires.Models.Units
{
    [Unit]
    public class Swordsman:Unit
    {
        private const int InitialHealth = 40;
        private const int DamageAttack = 13;
        public Swordsman():base(InitialHealth,DamageAttack)
        {

        }
    }
}
