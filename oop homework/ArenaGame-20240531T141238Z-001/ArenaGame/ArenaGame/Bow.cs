namespace ArenaGame
{
    public class Bow : Weapon
    {
        private const int DoubleShotChance = 15;

        public Bow() : base("Bow", 15)
        {
        }

        public override int UseSpecialAbility(int baseAttack)
        {
            if (ThrowDice(DoubleShotChance))
            {
                return baseAttack * 2; // Double shot: double damage
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
