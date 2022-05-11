using System;

namespace vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int nomevariavel;
             int[] nomevetor;
             char[] meunome;

             nomevetor = new int[10];
             nomevetor[0] = 3;

             meunome = new char[50];

             faça um programa que leia um numero x e na sequencia leia x valores depois imprima de traz pra frente os valores lidos
            */


            int x;
            int[] n;
            int.TryParse(Console.ReadLine(), out x);
            n = new int[x];


            for (int i = 0; i < x; i++)
            {
                int.TryParse(Console.ReadLine(), out n[i]);
            }

            for (int i = x - 1; i >= 0; i--)
            {
                Console.WriteLine(n[i]);
            }

           

            

           

            






            
            



            


           






            

            
            



        }
    }
}
