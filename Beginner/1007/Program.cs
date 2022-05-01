using System;
using System.Globalization;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine(),CultureInfo.InvariantCulture);
            int B = Convert.ToInt32(Console.ReadLine(),CultureInfo.InvariantCulture);
            int C = Convert.ToInt32(Console.ReadLine(),CultureInfo.InvariantCulture);
            int D = Convert.ToInt32(Console.ReadLine(),CultureInfo.InvariantCulture);

            int DIFERENCA = ((A * B) - (C * D));

            Console.Write("DIFERENCA = {0}\n", DIFERENCA.ToString(CultureInfo.InvariantCulture));

        }
    }
}