using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // Mesmo sendo um número, o tipo de dado capturado pelo console é um string, e precisa ser convertido dependendo do uso.

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Usar o "." como separador de casas decimais, independente da cultura do sistema.

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
