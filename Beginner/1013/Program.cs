using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             URI Online Judge | 1013 - O Maior

             Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da
             mensagem “eh o maior”. Utilize a fórmula: (a + b + abs(a - b)) / 2

            Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). 
            Um segundo passo, portanto é necessário para chegar no resultado esperado.

            Entrada
                O arquivo de entrada contém três valores inteiros.

            Saída
                Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
             */
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