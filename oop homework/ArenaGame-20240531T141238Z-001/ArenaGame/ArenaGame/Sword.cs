namespace ArenaGame
{
    public class Sword : Weapon
    {
        private const int CriticalHitChance = 10;

        public Sword() : base("Sword", 20)
        {
        }

        public override int UseSpecialAbility(int baseAttack)
        {
            if (ThrowDice(CriticalHitChance))
            {
                return baseAttack * 2;
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
