using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Wizard
    {
        public string Name { get; set; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }

        public Wizard(string name)
        {
            this.Name = name;
            this.AttackValue = 50;
            this.DefenseValue = 80;
            this.InitialHealth = 150;
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