using System;

namespace _1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string PROD;


            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("PROD = " + (a * b));

            
        }
    }
}
