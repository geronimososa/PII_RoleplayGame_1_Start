using System

namespace Ucu.Poo.RolePlayGame
{
    public class Elves
    {
        public string Name { get; set; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }

        public Elves(string name)
        {
            this.Name = name;
            this.AttackValue = 50;
            this.DefenseValue = 20;
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