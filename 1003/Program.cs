using System;

namespace _1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            double SOMA;

            
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);


            SOMA = (A + B);

            Console.WriteLine("SOMA = " + (A + B));




        }
    }
}
