using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Knight
    {
        public string Name { get; set; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }

        public Knight(string name)
        {
            this.Name = name;
            this.AttackValue = 150;
            this.DefenseValue = 100;
            this.InitialHealth = 300;
            this.Health = this.InitialHealth;
        }

        public void ReceiveAttack(int attackDamage)
        {
            int actualDamage = attackDamage - this.DefenseValue;
            if (actualDamage > 0)
            {
                this.Health -= actualDamage;
            }
        }

        public void Cure()
        {
            this.Health = this.InitialHealth;
        }

    }
}