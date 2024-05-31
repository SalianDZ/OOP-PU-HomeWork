namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }

        public Weapon EquippedWeapon { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
        }

        public virtual int Attack()
        {
            int baseAttack = (Strength * Random.Shared.Next(80, 121)) / 100;
            if (EquippedWeapon != null)
            {
                baseAttack += EquippedWeapon.AttackBoost;
                baseAttack = EquippedWeapon.UseSpecialAbility(baseAttack);
            }
            return baseAttack;
        }

        public void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health -= incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health += value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
