using System;

namespace _1067
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int X=0;

            int.TryParse(Console.ReadLine(), out X);

            for (int i = 1; i <= X; i++)
            {
                if (X % 2 <= X)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }



            
        }
    }
}
