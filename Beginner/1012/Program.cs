using System;
using System.Globalization;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double PI = 3.14159;

            //Linha 1
            String[] vetorDeLinhas = Console.ReadLine().Split(' ');
            a = double.Parse(vetorDeLinhas[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetorDeLinhas[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetorDeLinhas[2], CultureInfo.InvariantCulture);

            double areaDoTrianguloRetangulo = (a * c) / 2;
            double areaDoCirculo = PI * Math.Pow(c, 2);
            double areaDoTrapezio = ((a + b)*c)/2;
            double areaDoQuadrado = Math.Pow(b,2);
            double areaRetangulo = a * b;

            Console.Write("TRIANGULO: {0}\n",   areaDoTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("CIRCULO: {0}\n",     areaDoCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("TRAPEZIO: {0}\n",    areaDoTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("QUADRADO: {0}\n",    areaDoQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("RETANGULO: {0}\n",   areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}