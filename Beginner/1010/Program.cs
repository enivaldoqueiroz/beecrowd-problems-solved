using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, codigo2, quantidade1, quantidade2;
            double valorPeca1, valorPeca2, valorTotalAPagar;

            //Primeira linha
            String[] vetorPecaUm = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vetorPecaUm[0]);
            quantidade1 = int.Parse(vetorPecaUm[1]);
            valorPeca1 = double.Parse(vetorPecaUm[2], CultureInfo.InvariantCulture);

            //Segunda linha
            String[] vetorPecaDois = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vetorPecaDois[0]);
            quantidade2 = int.Parse(vetorPecaDois[1]);
            valorPeca2 = double.Parse(vetorPecaDois[2], CultureInfo.InvariantCulture);

            //Realizando o calculo;
            valorTotalAPagar = (quantidade1 * valorPeca1) + (quantidade2 * valorPeca2);

            //Imprimindo resultado;
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotalAPagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}