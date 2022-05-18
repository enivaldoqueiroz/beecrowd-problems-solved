using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Tempo de Jogo - beecrowd | 1046
              
                Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
                sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

                Entrada
                A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

                Saída
                Apresente a duração do jogo conforme exemplo abaixo.
             */

            int horaInicial, horaFinal;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicial > horaFinal)
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", (24 - horaInicial) + horaFinal);
            if (horaInicial == horaFinal)
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", 24);
            if (horaInicial < horaFinal)
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", horaFinal - horaInicial);
        }
    }
}
