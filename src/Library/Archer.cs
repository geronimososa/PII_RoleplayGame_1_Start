using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Archer
    {
        public string Name { get; set; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }

        public Archer(string name)
        {
            this.Name = name;
            this.AttackValue = 90;
            this.DefenseValue = 30;
            this.InitialHealth = 100;
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