using System;
using System.Globalization;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Teste de Seleção 1 - beecrowd | 1035

            Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

            Entrada
            Quatro números inteiros A, B, C e D.

            Saída
            Mostre a respectiva mensagem após a validação dos valores.

             */

            int A, B, C, D;

            string[] p1 = Console.ReadLine().Split(' ');
            A = int.Parse(p1[0], CultureInfo.InvariantCulture);
            B = int.Parse(p1[1], CultureInfo.InvariantCulture);
            C = int.Parse(p1[2], CultureInfo.InvariantCulture);
            D = int.Parse(p1[3], CultureInfo.InvariantCulture);

            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            //bool IsPasitivo(int x, int y)
            //{
            //    if (x > 0 && y > 0)
            //        return true;

            //    return false;
            //}

            //bool IsPar(int x)
            //{
            //    if (x % 2 == 0)
            //        return true;

            //    return false;
            //}
        }
    }
}
