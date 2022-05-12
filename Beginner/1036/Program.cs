using System;
using System.Globalization;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] v = Console.ReadLine().Split(' ');
            A = double.Parse(v[0], CultureInfo.InvariantCulture);
            B = double.Parse(v[1], CultureInfo.InvariantCulture);
            C = double.Parse(v[2], CultureInfo.InvariantCulture);

            double raizQuadradaDelta = Math.Sqrt(Math.Pow(B, 2) - 4 * A * C);
            
            double R1 = (-B + raizQuadradaDelta) / (2 * A);
            double R2 = (-B - raizQuadradaDelta) / (2 * A);

            if (A == 0 || B == 0 && C == 0 || raizQuadradaDelta < 0 || raizQuadradaDelta.Equals(double.NaN))
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = {0}", R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = {0}", R2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
