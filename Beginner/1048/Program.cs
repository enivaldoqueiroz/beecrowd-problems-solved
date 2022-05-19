using System;
using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 0 && salario <= 400.00)
                ImprimirRetorno(salario, 15);
            else if (salario >= 400.01 && salario <= 800.00)
                ImprimirRetorno(salario, 12);
            else if (salario >= 800.01 && salario <= 1200.00)
                ImprimirRetorno(salario, 10);
            else if (salario >= 1200.01 && salario <= 2000.00)
                ImprimirRetorno(salario, 7);
            else if (salario > 2000.00)
                ImprimirRetorno(salario, 4);

        }
            static void ImprimirRetorno(double salario, double percentual)
            {
                double novoSalario = salario + (salario * (percentual / 100));
                double reajusteGanho = salario * (percentual / 100);
                Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: {0}", reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
    }
}
