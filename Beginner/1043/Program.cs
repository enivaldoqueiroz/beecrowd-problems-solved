using System;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double perimetroDoTriangolo = a + b + c;
            double areaDoTrapezio = ((a + b) * c) / 2;

            if ((a < (b + c)) && (b < (a + c)) && (c < (b + a)))
                Console.WriteLine("Perimetro = {0}", perimetroDoTriangolo.ToString("F1", CultureInfo.InvariantCulture));
            else
                Console.WriteLine("Area = {0}", areaDoTrapezio.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
