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


            //1

            // request byte input
            Console.Write("Insere um número inteiro não-negativo: ");

            byte n = byte.Parse(Console.ReadLine()); 

            // print & decrementation
            Console.WriteLine(--n); 

            // print & increment
            Console.WriteLine(++n); 

            // 4

            // divided per 2
            Console.WriteLine(n/2); 

            // Xor left 3
            Console.WriteLine(n<<3); 

            // Xor with 5
            Console.WriteLine(n^5);



            if(n > 10) 
            {
                Console.WriteLine(true); 
            }

            else
            {
                Console.WriteLine(false); 
            }

        }
    }
}
