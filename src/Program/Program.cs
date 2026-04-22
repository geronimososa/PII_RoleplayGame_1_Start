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
            Gigant ogro = new Gigant("ogro");
            ogro.ReceiveAttack(200);
            Console.WriteLine("Gigante: " + ogro.Name);
            Console.WriteLine("Vida actual de " + ogro.Name + " es " + ogro.Health);
        }
    }
}
