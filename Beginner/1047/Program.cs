using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tempo de Jogo com Minutos - beecrowd | 1047
            
             Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. 
                A seguir calcule a duração do jogo.

                Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

                Entrada
                Quatro números inteiros representando a hora de início e fim do jogo.

                Saída
                Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .
             */

            int horaInicial, horaFinal, minutoInicial, minutoFinal;
            int hora = 0, minuto = 0, t1 = 0, t2 = 0, t3 = 0;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            t1 = horaInicial * 60 + minutoInicial;
            t2 = horaFinal * 60 + minutoFinal;

            if (t2 > t1)
                t3 = t2 - t1;
            else
                t3 = t2 - t1 + (24 * 60);

            hora = t3 / 60;
            minuto = t3 % 60;

            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hora, minuto);
        }
    }
}
