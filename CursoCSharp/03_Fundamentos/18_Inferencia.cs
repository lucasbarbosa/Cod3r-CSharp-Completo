using System;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo";
            // nome = 123; // Erro pois ouve uma inferência do tipo String na linha anterior
            Console.WriteLine(nome);

            // var teste; // Erro: variáveis de tipo implícito devem ser inicializadas
            // int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a; // Declaração
            a = 3; // Atribuição
            int b = 2; // Inicialização

            Console.WriteLine(a + b);
        }
    }
}
