using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {




            double numero1 = 0, numero2 = 0, resultado= 0 ;
            string operador = "";



            while (operador != "0")
            {

                Console.WriteLine(" Digite o numero 1:");
                Double.TryParse(Console.ReadLine(), out numero1);

                Console.WriteLine(" Digite o numero 2:");
                Double.TryParse(Console.ReadLine(), out numero2);




                while (operador != "0" )
                {
                    Console.WriteLine("digite o operador: + - * /");
                    operador = Console.ReadLine();

                    if (operador != "*" && operador != "/" && operador != "-" && operador != "+")
                    {
                        Console.WriteLine("Operador  invalido");
                        //continue;
                        
                    }
                    else 
                    {
                        break;
                    }

                }
               
                










                if (operador == "+")
                {
                    resultado = (numero1 + numero2);
                }

                if (operador == "-")
                {
                    resultado = (numero1 - numero2);
                }

                if (operador == "*")
                {
                    resultado = (numero1 * numero2);
                }

                if (operador == "/")
                {


                    if (numero2 == 0)
                    {
                        Console.WriteLine("nao e possivel dividir por zero");
                    }
                    else
                    {
                        resultado = (numero1 / numero2);
                    }
                }
                if (operador == "/" && numero2 == 0)
                {
                    Console.WriteLine("Nao divisivel por 0");
                }
                
                else if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                {
                    Console.WriteLine("seu resultado e:");
                    Console.WriteLine(resultado);
                }
            }
        }









    }       
       
}
