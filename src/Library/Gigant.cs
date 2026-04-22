using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Gigant
    {
        public string Name { get; set; }
        public int AttackValue { get; }
        public int DefenseValue { get; }
        public int Health { get; set; }

        public Gigant(string name)
        {
            Name = name;
            AttackValue = 100;
            DefenseValue = 50;
            Health = 500;
        }

        public void ReceiveAttack(int attackDamage)
        {
            int actualDamage = attackDamage - DefenseValue;
            if (actualDamage > 0)
            {
                Health -= actualDamage;
            }
        }

        public void Cure()
        {
            Health = 500;
        }
    }
}

