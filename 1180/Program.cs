using System;

namespace _1180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int.TryParse(Console.ReadLine(), out N);

            int[] X = new int[N];

            int MenorVetor=0;
            int MenorPosicao = 0;

            string Conteudo = Console.ReadLine();
            string[] Conteudo1 = Conteudo.Split(' ');


            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(Conteudo1[i]);
                
                if(i == 0)
                {
                    MenorVetor = X[i];
                    
                }
                else if (X[i] < MenorVetor)
                {
                    MenorVetor = X[i];
                    MenorPosicao = i;
                }
            }
            Console.WriteLine("Menor valor: " + MenorVetor);
            Console.WriteLine("Posicao: " + MenorPosicao); 
        }
    }
}
