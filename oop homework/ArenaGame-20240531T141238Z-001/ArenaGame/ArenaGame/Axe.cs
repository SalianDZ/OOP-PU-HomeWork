namespace ArenaGame
{
    public class Axe : Weapon
    {
        private const int BleedChance = 20;

        public Axe() : base("Axe", 25)
        {
        }

        public override int UseSpecialAbility(int baseAttack)
        {
            if (ThrowDice(BleedChance))
            {
                return baseAttack + 30; // Bleed effect: extra 30 damage
            }
            return baseAttack;
        }

        private bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }
    }
}
