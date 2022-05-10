using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Notas e Moedas - beecrowd | 1021

                Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

                Entrada
                O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

                Saída
                Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

                Obs: Utilize ponto (.) para separar a parte decimal. 

             */

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTAS:");
            int nota = (int)valor / 100;
            Console.WriteLine("{0} nota(s) de R$ 100.00", nota);
            valor = valor % 100;

            nota = (int)valor / 50;
            Console.WriteLine("{0} nota(s) de R$ 50.00", nota);
            valor = valor % 50;

            nota = (int)valor / 20;
            Console.WriteLine("{0} nota(s) de R$ 20.00", nota);
            valor = valor % 20;

            nota = (int)valor / 10;
            Console.WriteLine("{0} nota(s) de R$ 10.00", nota);
            valor = valor % 10;

            nota = (int)valor / 5;
            Console.WriteLine("{0} nota(s) de R$ 5.00", nota);
            valor = valor % 5;

            nota = (int)valor / 2;
            Console.WriteLine("{0} nota(s) de R$ 2.00", nota);
            valor = valor % 2;

            valor = valor * 100;

            Console.WriteLine("MOEDAS:");

            nota = (int)valor / 100;
            Console.WriteLine("{0} moeda(s) de R$ 1.00", nota);
            valor = valor % 100;

            nota = (int)valor / 50;
            Console.WriteLine("{0} moeda(s) de R$ 0.50", nota);
            valor = valor % 50;

            nota = (int)valor / 25;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", nota);
            valor = valor % 25;

            nota = (int)valor / 10;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", nota);
            valor = valor % 10;

            nota = (int)valor / 5;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", nota);
            valor = valor % 5;

            nota = (int)valor / 1;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", nota);
            valor = valor % 1;
        }
    }
}