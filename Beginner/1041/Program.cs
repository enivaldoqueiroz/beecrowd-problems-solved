using System;
using System.Globalization;

namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            string[] vetValores = Console.ReadLine().Split(' ');
            x = double.Parse(vetValores[0], CultureInfo.InvariantCulture);
            y = double.Parse(vetValores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
                Console.Write("Origem\n");
            else if (x == 0.0 && y != 0.0)
                Console.Write("Eixo Y\n");
            else if (x != 0.0 && y == 0.0)
                Console.Write("Eixo X\n");
            else if(x > 0.0 && y > 0.0)
                Console.Write("Q1\n");
            else if (x < 0.0 && y > 0.0)
                Console.Write("Q2\n");
            else if (x < 0.0 && y < 0.0)
                Console.Write("Q3\n");
            else if (x > 0.0 && y < 0.0)
                Console.Write("Q4\n");
        }
    }
}
