using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // 5
            Console.WriteLine(!booleano); // False

			numero1++; // Pós fixado (Após a execução)
            Console.WriteLine(numero1); // 3

			--numero1; // Pré fixado (Antes a execução)
            Console.WriteLine(numero1); // 2

			Console.WriteLine(numero1++ == --numero2); // True (2 == 2)
            Console.WriteLine($"{numero1} {numero2}"); // 3 2
		}
    }
}
