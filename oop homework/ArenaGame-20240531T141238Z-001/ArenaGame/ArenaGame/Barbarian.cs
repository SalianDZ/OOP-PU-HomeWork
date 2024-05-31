namespace ArenaGame
{
    public class Barbarian : Hero
    {
        private const int RageChance = 25;

        public Barbarian(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(RageChance))
            {
                attack = attack * 2; // Rage: double damage
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
        }
    }
}
