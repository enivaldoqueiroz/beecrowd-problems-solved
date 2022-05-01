using System;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine().Trim());
            int b = Int32.Parse(Console.ReadLine().Trim());

            int PROD = a * b;

            Console.Write("PROD = {0}\n", PROD);            
        }
    }
}
