using System;

namespace _1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();



            if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
            else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "onivoro")
            {
                Console.WriteLine("minhoca");
            }










        }
    }
}
