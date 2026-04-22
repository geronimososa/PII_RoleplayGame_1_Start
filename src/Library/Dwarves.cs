using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Dwarves
    {
        public string Name { get; set; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }
    

        public Dwarves(string name)
        {
            this.Name = name;
            this.AttackValue = 70;
            this.DefenseValue = 50;
            this.InitialHealth = 400;
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