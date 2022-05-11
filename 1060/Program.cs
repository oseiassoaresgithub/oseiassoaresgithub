using System;

namespace _1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int p = 0;
            double d;

            for (i = 0; i < 6; i++)
            {
                Double.TryParse(Console.ReadLine(), out d);


                if (d > 0)
                {
                    p++;
                }
            }

            Console.WriteLine($"{p} valores positivos");
            
            
                
                




        }
    }
}
