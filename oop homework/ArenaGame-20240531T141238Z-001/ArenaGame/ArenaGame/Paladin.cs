namespace ArenaGame
{
    public class Paladin : Hero
    {
        private const int HealOnAttackChance = 20;
        private const int BlockDamageChance = 15;

        public Paladin(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(HealOnAttackChance))
            {
                Heal(StartingHealth * 10 / 100); // Heal 10% of starting health on attack
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(BlockDamageChance)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
