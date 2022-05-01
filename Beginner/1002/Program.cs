using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio = Double.Parse(System.Console.ReadLine().Trim());
            double area = n * Math.Pow(raio,2);
            string valueArea = area.ToString(".0000");
            Console.Write("A = {0}\n", valueArea);
        }
    }
}
