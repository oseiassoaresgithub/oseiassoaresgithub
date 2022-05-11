using System;

namespace matriz // jogo da velha
{
    internal class Program
    {
        static int[,] jogo;
        const int LINHAS = 3, COLUNAS = 3;//CONSTANTE GLOBAL SEMPRE EM CAIXA ALTA
        static void Main(string[] args)
        {
            
            jogo = new int[LINHAS , COLUNAS];


            InicializarTabuleiro();

            int quemjoga = 1;
            bool continuarjogando = true;


            while (continuarjogando) // laço do jogo//
            {
                //imprimir quem joga
                ImprimirTabuleiro();
                //ler quem joga
                //registrar posição de jogada
                //checar quem ganhou
                //checar empate
                //alterar quem joga
                continuarjogando = false;

            }
        }

        static void ImprimirTabuleiro()
        {
            Console.WriteLine("tabuleiro");
            for (int i = 0; i < LINHAS; i++)
            {
                for(int j = 0; j < COLUNAS; j++)
                {
                    if (jogo [i ,j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (jogo [i ,j] == 1)
                    {
                        Console.Write(" X ");
                    }
                    else if (jogo [i ,j] == 2)
                    {
                        Console.Write(" O ");
                    }

                    if (j == 0 || j == 1)
                    {
                        Console.Write(" | ");
                    }
                        

                    
                }
                Console.WriteLine();
                if (i ==0 || i == 1)
                {
                    Console.WriteLine("--+---+--");
                }
            }
        }

        static void InicializarTabuleiro()
        {
            for (int i = 0; i < LINHAS; i++)
            {
                for (int j = 0; j < COLUNAS; j++)
                {
                    jogo[i, j] = 0;
                }

            }
        }
    }
}
