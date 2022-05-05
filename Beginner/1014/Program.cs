using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumoMedio = X / Y;

            Console.Write("{0} km/l\n", consumoMedio.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}