using System;

namespace MasterAndPlayer
{
    class Program
    {
        private static void Main(string[] args)
        {

            // request input
            Console.Write("Number master insert: ");

            // integer number conversion & input read
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n> 100)
            {
                Console.WriteLine
                ("Invalid number! Try again!");
            }
            else
            {
                for (int j = 0; j <=100; j++)
                {
                    Console.WriteLine("");
                }


            }

        }
    }
}
