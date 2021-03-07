using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50); // False

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete); // False

			var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // "OU" exclusivo, se os dois operadores forem True o resultado é False
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32); // False

			Console.WriteLine("Mais saudável? {0}", !comprouSorvete); // True
		}
    }
}
