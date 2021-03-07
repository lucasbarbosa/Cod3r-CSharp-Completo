using System;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            Console.WriteLine(somatorio); // 37.9

            double media = somatorio / notas.Length;
            Console.WriteLine(media); // 7.58

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra); // Array

            TesteArray();
        }

        #region Tests

        private static void TesteArray()
        {
            string[] nomes = new string[] { "Lucas", "Bia", "Fabi" };
            int[] numeros = new int[] { 33, 11, 46 };

            string[] a_CopyTo1 = new string[3];
            string[] a_CopyTo2 = new string[3];

            var a_Clone = nomes.Clone();
            nomes.CopyTo(a_CopyTo1, 0); // { "Lucas", "Bia", "Fabi" }

            var a_Equals1 = nomes.Equals(a_CopyTo1); // false
            var a_Equals2 = nomes.Equals(a_CopyTo2); // false
            var a_Equals3 = nomes.Equals(nomes); // true

            var a_GetEnumerator = nomes.GetEnumerator(); // {System.Array.SZArrayEnumerator}

            var a_GetHashCode1 = nomes.GetHashCode(); // 58225482
            var a_GetHashCode2 = a_CopyTo1.GetHashCode(); // 58225482
            var a_GetHashCode3 = a_CopyTo2.GetHashCode(); // 18643596

            var a_GetType = nomes.GetType(); // {Name = "String[]" FullName = "System.String[]"}
            var a_GetValue = nomes.GetValue(2); // Fabi

            nomes.Initialize();

            var a_IsFixedSize = nomes.IsFixedSize; // true
            var a_IsReadOnly = nomes.IsReadOnly; // false
            var a_IsSynchronized = nomes.IsSynchronized; // false
            var a_Length1 = nomes.Length; // 3
            var a_LongLength = nomes.LongLength; // 3
            var a_Rank = nomes.Rank; // 1

            nomes.SetValue("Fabiana", 2);

            // var a_SyncRoot = nomes.SyncRoot

            var a_ToString = numeros.ToString(); // System.Int32[]

            string[,] matriz = new string[,]{
                {"1.1", "1.2", "1.3", "1.4"},
                {"2.1", "2.2", "2.3", "2.4"},
                {"3.1", "3.2", "3.3", "3.4"}
            };

            var a_GetLength1 = matriz.GetLength(0); // 3
            var a_GetLength2 = matriz.GetLength(1); // 4
            var a_Length2 = matriz.Length; // 12

            var a_GetLongLength1 = matriz.GetLongLength(0); // 3
            var a_GetLongLength2 = matriz.GetLongLength(1); // 4

            var a_GetLowerBound1 = matriz.GetLowerBound(0); // 0
            var a_GetLowerBound2 = matriz.GetLowerBound(1); // 0

            var a_GetUpperBound1 = matriz.GetUpperBound(0); // 2
            var a_GetUpperBound2 = matriz.GetUpperBound(1); // 3


            lock (numeros.SyncRoot) // Bloquear durante a enumeração
            {
                foreach (Object item in numeros)
                    Console.WriteLine(item);
            }
        }

        #endregion
    }
}
