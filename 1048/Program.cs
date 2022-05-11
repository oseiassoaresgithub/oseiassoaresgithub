using System;

namespace _1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario=0;
            


            Double.TryParse(Console.ReadLine(), out salario);


            if (salario >=0 && salario <= 400.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * 0.15)).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(salario * 0.15).ToString("F2")}");
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * 0.12)).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(salario * 0.12).ToString("F2")}");
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * 0.10)).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(salario * 0.10).ToString("F2")}");
                Console.WriteLine("Em percentual: 10 %");
            }
            else if(salario >= 1200.01 && salario <= 2000.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * 0.07)).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(salario * 0.07).ToString("F2")}");
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                Console.WriteLine($"Novo salario: {(salario + (salario * 0.04)).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(salario * 0.04).ToString("F2")}");
                Console.WriteLine("Em percentual: 4 %");
            }
                    

            
                   

                   

            


            
        }
        
    }
}
