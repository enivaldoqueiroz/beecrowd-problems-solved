using System;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Animal - beecrowd | 1049*/

            string a, b, c;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            if (a.Equals("vertebrado") && b.Equals("ave") && c.Equals("carnivoro"))
                Console.WriteLine("aguia");
            if (a.Equals("vertebrado") && b.Equals("ave") && c.Equals("onivoro"))
                Console.WriteLine("pomba");
            if (a.Equals("vertebrado") && b.Equals("mamifero") && c.Equals("onivoro"))
                Console.WriteLine("homem");
            if (a.Equals("vertebrado") && b.Equals("mamifero") && c.Equals("herbivoro"))
                Console.WriteLine("vaca");
            if (a.Equals("invertebrado") && b.Equals("inseto") && c.Equals("hematofago"))
                Console.WriteLine("pulga");
            if (a.Equals("invertebrado") && b.Equals("inseto") && c.Equals("herbivoro"))
                Console.WriteLine("lagarta");
            if (a.Equals("invertebrado") && b.Equals("anelideo") && c.Equals("hematofago"))
                Console.WriteLine("sanguessuga");
            if (a.Equals("invertebrado") && b.Equals("anelideo") && c.Equals("onivoro"))
                Console.WriteLine("minhoca");
        }
    }
}
