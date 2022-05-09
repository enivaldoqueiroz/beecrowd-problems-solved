using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            Idade em Dias -  beecrowd | 1020
                    
            Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

            Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

            Entrada
                O arquivo de entrada contém um valor inteiro.

            Saída
            Imprima a saída conforme exemplo fornecido
             */
            int numerosDeDias = int.Parse(Console.ReadLine());

            int anos = numerosDeDias / 365;
            int restoAnos = numerosDeDias % 365;

            int mes = restoAnos / 30;
            int restoMes = restoAnos % 30;
            int dias = restoMes / 1;

            Console.WriteLine("{0} ano(s)", anos);
            Console.WriteLine("{0} mes(es)", mes);
            Console.WriteLine("{0} dia(s)",dias);
        }
    }
}
