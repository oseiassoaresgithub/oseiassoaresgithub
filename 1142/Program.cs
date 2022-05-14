using System;

namespace _1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int numero; 


            int.TryParse(Console.ReadLine(), out n);


            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    numero = i;
                    Console.WriteLine($"{numero} {numero  + 1} {numero + 2} PUM");
                    i = i + 4;
                    numero++;
                }
                    
            }
        }
    }
}