using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Cédulas - beecrowd | 1018

             Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas)
             no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. 
             A seguir mostre o valor lido e a relação de notas necessárias.

               Entrada
               O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

               Saída
               Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
             */

            int x = int.Parse(Console.ReadLine());

            int notas100 = x / 100;
            int restoDivPor100 = x % 100;

            int notas50 = restoDivPor100 / 50;
            int restoDivPor50 = restoDivPor100 % 50;

            int notas20 = restoDivPor50 / 20;
            int restoDivPor20 = restoDivPor50 % 20;

            int notas10 = restoDivPor20 / 10;
            int restoDivPor10 = restoDivPor20 % 10;

            int notas5 = restoDivPor10 / 5;
            int restoDivPor5 = restoDivPor10 % 5;

            int notas2 = restoDivPor5 / 2;
            int restoDivPor2 = restoDivPor5 % 2;

            int notas1 = restoDivPor2 / 1;
            int restoDivPor1 = restoDivPor2 % 1;

            Console.WriteLine(x);
            Console.WriteLine("{0} nota(s) de R$ 100,00\n", notas100);
            Console.WriteLine("{0} nota(s) de R$ 50,00\n", notas50);
            Console.WriteLine("{0} nota(s) de R$ 20,00\n", notas20);
            Console.WriteLine("{0} nota(s) de R$ 10,00\n", notas10);
            Console.WriteLine("{0} nota(s) de R$ 5,00\n", notas5);
            Console.WriteLine("{0} nota(s) de R$ 2,00\n", notas2);
            Console.WriteLine("{0} nota(s) de R$ 1,00\n", notas1);

        }
    }
}
