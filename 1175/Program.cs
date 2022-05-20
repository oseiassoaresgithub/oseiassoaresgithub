using System;

namespace _1175
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[20];
            int Y;
                   
                             

            for (int i = 0; i < 20; i++)
            {
                int.TryParse(Console.ReadLine(), out N[i]);
            }

            for(int i = 0; i < 10; i++)
            {
                Y=N[i];
                N[i] = N[19-i];
                N[19- i] = Y;                               

            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"N[{i}] = {N[i]}");
            }

        }    
    }
}
