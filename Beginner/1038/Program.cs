using System;
using System.Globalization;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;

            string[] vetValores = Console.ReadLine().Split(' ');
            codigo = int.Parse(vetValores[0]);
            quantidade = int.Parse(vetValores[1]);

            double valorTotal = 0;
            switch (codigo)
            {
                case 1:
                    valorTotal = 4.00 * quantidade;
                    Console.WriteLine("Total: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    valorTotal = 4.50 * quantidade;
                    Console.WriteLine("Total: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    valorTotal = 5.00 * quantidade;
                    Console.WriteLine("Total: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    valorTotal = 2.00 * quantidade;
                    Console.WriteLine("Total: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    valorTotal = 1.50 * quantidade;
                    Console.WriteLine("Total: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
        }
    }
}
