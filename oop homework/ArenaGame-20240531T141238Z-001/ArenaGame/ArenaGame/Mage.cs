namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int FireballChance = 20;
        private const int HealChance = 10;

        public Mage(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(FireballChance))
            {
                attack += 50; // Fireball: extra 50 damage
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(HealChance))
            {
                Heal(StartingHealth * 30 / 100); // Heal 30% of starting health
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
