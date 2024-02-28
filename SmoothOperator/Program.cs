using System;

namespace SmoothOperator
{
    /// <summary>
    /// Represents basic program that decrements and increments a byte
    /// </summary>
    class Program
    {
        /// <summary>
        ///  Request input for a non-negative number
        ///  Converts to a byte
        ///  Prints a decrementation & incrementation of this number
        /// </summary>
        /// <param name="args">Not used</param>
        private static void Main(string[] args)
        {

            // request byte input
            Console.Write("Insere um número inteiro não-negativo: ");

            byte n = byte.Parse(Console.ReadLine()); 

            // print & decrementation
            Console.WriteLine(--n); 

            // print & increment
            Console.WriteLine(++n); 
        }
    }
}
