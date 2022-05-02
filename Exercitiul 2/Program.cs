using System;

namespace Exercitiul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti trei numere: ");
            int numar1 = Convert.ToInt32(Console.ReadLine());
            int numar2 = Convert.ToInt32(Console.ReadLine());
            int numar3 = Convert.ToInt32(Console.ReadLine());

            int media = (numar1 + numar2 + numar3) / 3;
            Console.WriteLine("Media aritmetica este = " + media);
        }
    }
}
