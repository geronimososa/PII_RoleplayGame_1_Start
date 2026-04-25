//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main(string[] args)
        {
            Giant ogro = new Giant("ogro");
            ogro.ReceiveAttack(200);
            Console.WriteLine("Gigante: " + ogro.Name);
            Console.WriteLine("Vida actual de " + ogro.Name + " es " + ogro.Health);

            Wizard mago = new Wizard("Mago de fuego");
            Console.WriteLine("Mago: " + mago.Name);
            Console.WriteLine("Vida actual de " + mago.Name + " es " + mago.Health);
            Spell fireball = new Spell("Bola de fuego", 40, 0);
            mago.SpellsBook.AddSpell(fireball);
            Console.WriteLine("Ataque total de " + mago.Name + " es " + mago.GetTotalAttack());
            Console.WriteLine("Defensa total de " + mago.Name + " es " + mago.GetTotalDefense());  

            Elves elfo = new Elves("Elfo del bosque");
            Spell arrow = new Spell("Flecha mágica", 30, 0);
            elfo.SpellsBook.AddSpell(arrow);
            Console.WriteLine("Elfo: " + elfo.Name);
            Console.WriteLine("Ataque total de " + elfo.Name + " es " + elfo.GetTotalAttack());
            Console.WriteLine("Defensa total de " + elfo.Name + " es " + elfo.GetTotalDefense());
        }
    }
}
