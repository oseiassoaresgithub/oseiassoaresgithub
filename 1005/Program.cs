using System;

namespace _1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double media;

           

            Double.TryParse(Console.ReadLine(), out A);
            Double.TryParse(Console.ReadLine(), out B);



            media = (A * 3.5 + B * 7.5) / 11;


            Console.WriteLine("MEDIA = " + media.ToString("F5"));












            


            





        }
    }
}
