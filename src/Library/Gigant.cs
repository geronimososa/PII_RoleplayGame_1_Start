using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Gigant
    {
        public string Name { get; set; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        public int Health { get; set; }

        public Gigant(string name)
        {
            this.Name = name;
            this.AttackValue = 100;
            this.DefenseValue = 0;
            this.Health = 500;
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
            this.Health = 500;
        }
    }
}

