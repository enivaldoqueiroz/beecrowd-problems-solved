using System;
using System.Globalization;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor = Console.ReadLine();
            double salarioFixo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalDeVendaNoMes = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalAReceberNoFinalDoMes = salarioFixo + (totalDeVendaNoMes * 0.15);

            Console.Write("TOTAL = R$ {0}\n", totalAReceberNoFinalDoMes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
