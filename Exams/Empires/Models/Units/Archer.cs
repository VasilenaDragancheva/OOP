using Empires.Attributes;

namespace Empires.Models.Units
{
    [Unit]
    public class Archer:Unit
    {
        private const int InitialHealth = 25;
        private const int DamageAttack = 7;

        public Archer():base(InitialHealth,DamageAttack)
        {
        }

    }
}
