using System;

namespace _1173
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, V;

            int[] N = new int[10];


            int.TryParse(Console.ReadLine(), out V);

            X = V;

            for (int i = 0; i < 10; i++)
            {
                N[i] = X;

                X = X * 2;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"N[{i}] = " + N[i]);
            }
        }
    }
}
