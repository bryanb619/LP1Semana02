using System;

namespace MasterAndPlayer
{
    class Program
    {
        private static void Main(string[] args)
        {

            // request input
            Console.WriteLine("Insere um número inteiro entre 0 e 100");

            // integer number conversion & input read
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n> 100)
            {
                Console.WriteLine
                ("Erro, número inserido deve ser entre 0 e 100");
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
