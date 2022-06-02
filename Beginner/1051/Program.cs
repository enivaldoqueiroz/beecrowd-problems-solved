using System;
using System.Globalization;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada, resultado = 0, t1 = 0, t2 = 0, t3 = 0;
            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada <= 2000.00)
            {
                Console.WriteLine("Insento");
            }
            else
            {
                if (entrada > 2000.01 && entrada <= 3000.00)
                {
                    t1 = entrada - 2000;
                    t1 = ((t1 * 8) / 100);
                    resultado = t1;
                }
                else if (entrada > 3000.00 && entrada <= 4500.00)
                {
                    t1 = entrada - 2000;
                    t2 = t1 - 1000;
                    t1 -= t2;
                    t1 = ((t1 * 8) / 100);
                    t2 = ((t2 * 18) /100);
                    resultado = t2 + t1;
                }
                else if (entrada > 4500.00)
                {
                    t1 = entrada - 2000;
                    t2 = t1 - 1000;
                    t3 = t2 - 1500;
                    t1 -= t2;
                    t2 -= t3;
                    t1 = ((t1 * 8) / 100);
                    t2 = ((t2 * 18) / 100);
                    t3 = ((t3 * 28) / 100);
                    resultado =  t3 + t2 + t1;
                }

                Console.WriteLine("{0}", resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
