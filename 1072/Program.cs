using System;

namespace _1072
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N=0;
            int dentro=0;
            int fora = 0;
            int X;


            
            

            int.TryParse(Console.ReadLine(), out N);

            for (int i=0; i < N ; i++)
            {
                int.TryParse( Console.ReadLine(), out X);
                
                if (X >=10 && X <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
                
                   
                    
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");


        }
    }
}
