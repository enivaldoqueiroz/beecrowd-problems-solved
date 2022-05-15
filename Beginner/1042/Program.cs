using System;
using System.Globalization;
namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

                Entrada
                A entrada contem três números inteiros.

                Saída
                Imprima a saída conforme foi especificado.
             */


            int v1, v2, v3, min1, min2 = 0, min3 = 0;

            string[] vetValores = Console.ReadLine().Split(' ');
            v1 = int.Parse(vetValores[0], CultureInfo.InvariantCulture);
            v2 = int.Parse(vetValores[1], CultureInfo.InvariantCulture);
            v3 = int.Parse(vetValores[2], CultureInfo.InvariantCulture);

            //1º Modo de resolver

            min1 = Math.Min(v1, Math.Min(v2, v3));

            if (min1 == v1)
            {
                min2 = Math.Min(v2, v3);
                min3 = Math.Max(v2, v3);
            }
            if (min1 == v2)
            {
                min2 = Math.Min(v1, v3);
                min3 = Math.Max(v1, v3);
            }
            if (min1 == v3)
            {
                min2 = Math.Min(v1, v2);
                min3 = Math.Max(v1, v2);
            }

            Console.Write("{0}\n{1}\n{2}\n\n", min1, min2, min3);
            Console.Write("{0}\n{1}\n{2}\n", v1, v2, v3);

            /*
            //2º Modo de resolver

            int[] novoVetor = { v1, v2, v3 };
            Array.Sort(novoVetor);

            foreach (var item in novoVetor)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(" ");

            for (int i = 0; i < vetValores.Length; i++)
            {
                Console.WriteLine(vetValores[i]);
            }
            */

            /*
            
            //3º Mode de resolver
            int[] novoVetor = { v1, v2, v3 };

            //Ordenação em ordem decrescente
            for (int i = 0; i < novoVetor.Length; i++)
            {
                for (int j = 0; j < novoVetor.Length; j++)
                {
                    if (novoVetor[i] < novoVetor[j])
                    {
                        aux = novoVetor[i];
                        novoVetor[i] = novoVetor[j];
                        novoVetor[j] = aux;

                    }
                }
            }

            for (int i = 0; i < novoVetor.Length; i++)
            {
                Console.WriteLine(novoVetor[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < vetValores.Length; i++)
            {
                Console.WriteLine(vetValores[i]);
            }*/
        }
    }
}
