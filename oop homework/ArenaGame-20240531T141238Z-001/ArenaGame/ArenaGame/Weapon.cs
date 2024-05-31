namespace ArenaGame
{
    public abstract class Weapon
    {
        public string Name { get; protected set; }
        public int AttackBoost { get; protected set; }

        public Weapon(string name, int attackBoost)
        {
            Name = name;
            AttackBoost = attackBoost;
        }

        public abstract int UseSpecialAbility(int baseAttack);

    }
}
