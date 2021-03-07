using System;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 23)); // 33
            Console.WriteLine(Somar(50)); // 51
            Console.WriteLine(Somar()); // 2
            Console.WriteLine(Somar(b: 7)); // 8
        }
    }
}
