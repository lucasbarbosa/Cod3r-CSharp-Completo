using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 15.2 => Uma casa decimal
            Console.WriteLine(valor.ToString("C")); // R$ 15,18 => Valor monetário (Sistema)
			Console.WriteLine(valor.ToString("P")); // 1.517,50% => x100 Percentual
			Console.WriteLine(valor.ToString("#.##")); // 15,18 => Duas casas decimais

			CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); // $15 => Valor monetário sem casa decimal (Cultura específica)

			int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // 0000000256 => Número com X dígitos de caracteres
		}
    }
}
