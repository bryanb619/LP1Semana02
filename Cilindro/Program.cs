using System;

namespace Cilindro
{
    class Program
    {
        private static void Main(string[] args)
        {

            // Cylinder Height (a)
            Console.Write("Insere a altura de um cilindro");

            // input & conversion for height (a)
            float a  = float.Parse(Console.ReadLine()); 

            // Cylinder Radius (r)
            Console.Write("Insere o raio de um cilindro");

            // input & conversion for height (r)
            float r = float.Parse(Console.ReadLine()); 

            // volume equation
            float v = MathF.PI * MathF.Pow(r,2) * a; 

            




        }
    }
}
