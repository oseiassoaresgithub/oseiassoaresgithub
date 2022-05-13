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

            int contador = 0;

            int quemjoga = 1;
            bool continuarjogando = true;
            bool checarganhador, checarEmpate;
            string posicaojogada;


            while (continuarjogando) // laço do jogo//
            {
                


                //imprimir quem joga
                ImprimirTabuleiro();
                //ler quem joga
                posicaojogada = LerPosicaoJogador(quemjoga);

                //registrar posição de jogada
                RegistrarPosicaoJogador(quemjoga, posicaojogada);
                //checar quem ganhou
                checarganhador = ChecarGanhador(quemjoga);
                
                //checar empate
                if (checarganhador == false)
                {
                    checarEmpate = ChecarEmpate();
                    if(checarEmpate == true)
                    {
                        Console.WriteLine("Houve Empate!");
                        continuarjogando=false;
                    }
                }
                else
                {
                    Console.WriteLine($" {quemjoga} é o vencedor!");
                    continuarjogando=false;
                }


                //alterar quem joga
                if (quemjoga == 1)
                {
                    quemjoga = 2;
                }else if (quemjoga == 2)
                {
                    quemjoga = 1;
                }

                
                //continuarjogando = false;
                


            }
            ImprimirTabuleiro();
        }

        static bool ChecarEmpate()
        {
            for (int i = 0; i < LINHAS; i++)
            {
                for (int j = 0; j < COLUNAS; j++)
                {
                    if (jogo[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool ChecarGanhador(int quemjoga)
        {
            if (jogo[0, 0] == quemjoga && jogo[0, 1] == quemjoga && jogo[0, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[1, 0] == quemjoga && jogo[1, 1] == quemjoga && jogo[1, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[2, 0] == quemjoga && jogo[2, 1] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemjoga && jogo[1, 0] == quemjoga && jogo[2, 0] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 1] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 1] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemjoga && jogo[1, 2] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 0] == quemjoga)
            {
                return true;
            }
            return false;

        }

        static void RegistrarPosicaoJogador(int quemjoga, string posicaojogada)
        {
            int x, y;
            var posicoes = posicaojogada.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);

            jogo[x, y] = quemjoga;
        }




        static string LerPosicaoJogador(int quemjoga)
        {
            Console.WriteLine($"jogador {quemjoga} é a sua vez! escolha uma posicao ");
            string linha;
            int x, y;
            /*
             * 0 0 | 0 1 | 0 2
             * 1 0 | 1 1 | 1 2
             * 2 0 | 2 1 | 2 2
             */
            linha = Console.ReadLine();// 0 2
            var posicoes = linha.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);


            if (jogo[x, y] == 0)
            {
                // posicao nao jogada
                return linha;
            }
            return "";

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
                        Console.Write("   ");
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
                        Console.Write("|");
                    }
                        

                    
                }
                Console.WriteLine();
                if (i ==0 || i == 1)
                {
                    Console.WriteLine("---+---+---");
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
