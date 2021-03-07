using System;

namespace CursoCSharp.Fundamentos
{
    /// <summary>
    ///
    /// </summary>
    class Comentarios
    {
        public static void Executar()
        {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            /*
             * Esse é um comentário
             * de múltiplas linhas...
             */
            Console.WriteLine("O C# tem o XML Comments");
        }

        /// <summary>
        /// Apertar "/" 3x para criar o sumário
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static void Executar(int a, double b, string c)
        {
        }
    }
}
