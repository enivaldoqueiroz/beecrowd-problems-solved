using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Conversão de Tempo - beecrowd | 1019
            
             Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
             e informe-o expresso no formato horas:minutos:segundos.

             Entrada
             O arquivo de entrada contém um valor inteiro N.

             Saída
             Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, 
             conforme exemplo fornecido.
             */

            int valorEmSegundos = int.Parse(Console.ReadLine());

            int segundos = valorEmSegundos % 60;
            int minutos = valorEmSegundos / 60;
            int horas = minutos / 60;
            minutos = minutos % 60;

            Console.WriteLine("{0}:{1}:{2}\n", horas, minutos, segundos);

        }
    }
}
