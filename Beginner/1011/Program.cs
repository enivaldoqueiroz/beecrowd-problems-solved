using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double PI = 3.14159;
            double volumeRaio = (4.0/3) * PI * Math.Pow(R,3);

            Console.Write("VOLUME = {0}\n", volumeRaio.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}