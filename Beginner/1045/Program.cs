using System;
using System.Globalization;

namespace _1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, aux = 0;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double[] novoVet = { a, b, c };
            for (int i = 0; i < novoVet.Length; i++)
            {
                for (int j = 0; j < novoVet.Length; j++)
                {
                    if (novoVet[i] > novoVet[j])
                    {
                        aux = novoVet[i];
                        novoVet[i] = novoVet[j];
                        novoVet[j] = aux;
                    }
                }
            }

            if (novoVet[0] >= (novoVet[1] + novoVet[2]))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (Math.Pow(novoVet[0],2) > (Math.Pow(novoVet[1],2) + Math.Pow(novoVet[2],2)))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            if (Math.Pow(novoVet[0],2) == (Math.Pow(novoVet[1],2) + Math.Pow(novoVet[2],2)))
                Console.WriteLine("TRIANGULO RETANGULO");
            if (Math.Pow(novoVet[0],2) < (Math.Pow(novoVet[1],2) + Math.Pow(novoVet[2],2)))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (novoVet[0].Equals(novoVet[1]) && novoVet[1].Equals(novoVet[2]))
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((novoVet[0].Equals(novoVet[1]) && !novoVet[1].Equals(novoVet[2]))||
                (novoVet[0].Equals(novoVet[2]) && !novoVet[2].Equals(novoVet[1]))||
                (novoVet[1].Equals(novoVet[2]) && !novoVet[2].Equals(novoVet[0])))
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}
