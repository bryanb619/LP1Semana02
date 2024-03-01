using System;

namespace MasterAndPlayer
{
    class Program
    {
        private static void Main(string[] args)
        {

            bool playerWins = false; 

            // request input
            Console.Write("Number master insert: ");

            // integer number conversion & input read
            int n = int.Parse(Console.ReadLine());

            // check if lower or higher then 100
            if (n < 0 || n> 100)
            {
                Console.WriteLine
                ("Invalid number! Try again!");
            }
            else
            {
                // print nothing 100 times
                for (int j = 0; j <=100; j++)
                {
                    Console.WriteLine("");
                }


                while(!playerWins)
                {
                    // request input
                    Console.Write("Player insert number: "); 

                    // integer number conversion & input read
                    int i = int.Parse(Console.ReadLine());

                    // check if i is lower or higher then 100
                    if(i < 0 || i> 100)
                    {   
                        // print error message
                        Console.WriteLine("Invalid number! Try Again!"); 

                    }

                    // check if i is lower then n
                    if (i < n)
                    {
                        // print hint message
                        Console.WriteLine($"Valid number is higher then {i}");
                    }

                    // check if i higher then n 
                    else if(i > n)
                    {
                        // print hint message
                        Console.WriteLine($"Valid number is lower then {i}");

                    }

                    else if (i == n)
                    {
                        Console.WriteLine("Player wins"); 
                        playerWins = true; 
                      
                    }

                }


            

            }

            

            

        }
    }
}
