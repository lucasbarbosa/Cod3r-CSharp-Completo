using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", totalComDesconto); // O preço final é 1219,5

			// IMC
			double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Potência
            Console.WriteLine($"IMC é {imc}."); // IMC é 27,5329066537858.

			// Número Par/Impar
			int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); // 24 / 2 tem resto 0
			Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2); // 55 / 2 tem resto 1
		}
    }
}
