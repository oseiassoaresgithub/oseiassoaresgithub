using System;

namespace _1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X=0;
            int Y=0;

            int.TryParse(Console.ReadLine(), out X);

            for (int i = X, y=1; y <=  6; i++) { 
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    y++;
                    
                }
            }
        }
    }
}
