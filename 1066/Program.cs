using System;

namespace _1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int par=0;  
            int impar=0;
            int negativo=0;
            int positivo=0;

            
           
            for (int i = 0; i < 5; i++)
            {
                int.TryParse(Console.ReadLine(), out numero);
                if (numero % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                if (numero > 0)
                {
                    positivo++;
                }
                else if (numero < 0)
                {
                    negativo++;
                }


               

            }
            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");















        }
    }
}
