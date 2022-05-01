using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            int numeroHorasTrabalho = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorReceberPorHoraTrabalho = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioFuncionario = numeroHorasTrabalho * valorReceberPorHoraTrabalho;

            Console.Write("NUMBER = {0}\n", numero);
            Console.Write("SALARY = U$ {0}\n", salarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}