using System;

namespace Constante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * a primeira tem peso 30%
             * a segunda tem peso 50%
             * a terceira tem peso de 20%
             * imprimir a media 
             * dizer se foi aprovado ou nao
             */


            double nota1;
            double nota2;
            double nota3;
            double media;

            const double prova1 = 0.30;
            const double prova2 = 0.50;
            const double prova3 = 0.20;



            Console.WriteLine("digite a nota 1:");
            Double.TryParse(Console.ReadLine(), out nota1);


            Console.WriteLine("digite a nota 2:");
            Double.TryParse(Console.ReadLine(), out nota2);



            Console.WriteLine("digite a nota 3:");
            Double.TryParse(Console.ReadLine(), out nota3);


            nota1 = nota1 * prova1;
            nota2 = nota2 * prova2;
            nota3 = nota3 * prova3;


            media = (nota1 + nota2 + nota3);
            Console.WriteLine("sua note e:");
            Console.WriteLine(media);

            if (media >= 7)
            {
                Console.WriteLine("parabens voce foi aprovado:");
            }
            else
            {
                Console.WriteLine("voce foi reprovado");
            }


















        }
    }
}
