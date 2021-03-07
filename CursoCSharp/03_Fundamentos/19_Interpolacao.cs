using System;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + "."); // Concatenação
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco); // Interpolação
            Console.WriteLine($"A marca {marca} é legal!"); // Interpolação - Similar ao template literals de JS
            Console.WriteLine($"1 + 1 = {1 + 1}!"); // Interpolação - Similar ao template literals de JS
        }
    }
}
