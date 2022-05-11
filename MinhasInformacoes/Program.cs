using System;

namespace MinhasInformacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double peso;
            int idade;

            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o peso:");
            Double.TryParse(Console.ReadLine(), out peso);


            Console.WriteLine("digite a idade:");
            int.TryParse(Console.ReadLine(), out idade);

            
            Console.WriteLine("Seu nome e:");
            Console.WriteLine(nome);

            Console.WriteLine("seu peso e:");
            Console.WriteLine(peso);

            Console.WriteLine("sua idade e");
            Console.WriteLine(idade);










          }
    }
}
