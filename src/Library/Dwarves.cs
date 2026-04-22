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
    }
}