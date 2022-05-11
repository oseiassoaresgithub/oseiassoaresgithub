using System;

namespace exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double numero1;
            double numero2;

            for (contador = 0, numero1 = 0; contador <= 100; contador += 2)
            {
                if (contador % 2 == 0)
                {
                    numero1 = contador * 3;
                }
                else
                {
                    numero2 = contador + 9;
                }
            }


        }
    }
}
