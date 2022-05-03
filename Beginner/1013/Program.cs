using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            string[] vetorDeValoresEmLinha = Console.ReadLine().Split();
            a = int.Parse(vetorDeValoresEmLinha[0]);
            b = int.Parse(vetorDeValoresEmLinha[1]);
            c = int.Parse(vetorDeValoresEmLinha[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;

            int maiorABeC = (maiorAB + c + Math.Abs( maiorAB - c)) / 2;

            if (maiorAB > maiorABeC)
            {
                Console.Write("{0} eh o maior\n", maiorAB);
            }
            else
            {
                Console.Write("{0} eh o maior\n", maiorABeC);
            }
        }
    }
}