using System;

namespace _1174
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[100];
            

            

            

            for(int i = 0; i < 100; i++)
            {
                double.TryParse(Console.ReadLine(), out A[i]);
              
            }
            for(int i = 0; i < 100; i++)
            {
                
                if (A[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = " + A[i].ToString("F1"));
                }
            }
            

        }
    }
}
