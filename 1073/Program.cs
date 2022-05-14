using System;

namespace _1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int Y;

            int.TryParse(Console.ReadLine(), out N);

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Y = i * i;
                    Console.WriteLine(i + "^2 = " + Y);
                }
            }
        }

    }
}
    