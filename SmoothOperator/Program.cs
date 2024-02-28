using System;

namespace SmoothOperator
{
    /// <summary>
    /// Represents basic program that decrements and increments a byte
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">Not used</param>
        private static void Main(string[] args)
        {

            // request byte input
            Console.Write("Insere um número inteiro não-negativo: ");

            // byte declaration
            byte n; 

            // converion & readline
            n = byte.Parse(Console.Readline()); 

            // print & decrementation
            Console.WriteLine(n--); 

            // print & increment
            Console.WriteLine(n++); 
        }
    }
}
