using System;

namespace _1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int p = 0;
            double d;
            double media = 0;

            for (int i = 0; i < 6; i++)
            {
                Double.TryParse(Console.ReadLine(), out d);


                if (d > 0)
                {
                    p++;
                    media = media + d;
                }
            }

            media = media / p;

        

            Console.WriteLine($"{p} valores positivos");
            Console.WriteLine(media.ToString("F1"));
           

            

        }
           
        
    }
}
