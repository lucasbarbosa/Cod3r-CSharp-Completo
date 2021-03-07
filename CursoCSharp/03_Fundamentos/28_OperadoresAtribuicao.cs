using System;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1); // 35

            int a = 1;
            int b = a; // Atribuição valor (Cópia)

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}"); // 2 0


            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c; // Atribuição referência (Mesmo espaço na memória)
            d.nome = "Maria";

            Console.WriteLine(c.nome); // Maria
        }
    }
}
