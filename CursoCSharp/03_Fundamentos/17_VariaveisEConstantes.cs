using System;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            #region Área da circunferencia

            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415; // Não é possível alterar uma constante

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            #endregion

            #region Tipos Internos

            // Bool (1 byte): false => true
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);
            TestBool();

            // Byte (1 byte): 0 => 255
            byte idade = 45;
            Console.WriteLine("Idade: " + idade);
            TestByte();

            // Sbyte (1 byte): -128 => 127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);
            TestSbyte();

            // Short (2 bytes): -32.768 => 32.767
            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);
            TestShort();

            // Int (4 bytes): -2.147.483.648 => 2.147.483.647
            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int: " + menorValorInt);
            TestInt();

            // Uint (4 bytes): 0 => 4.294.967.295
            uint populacaoBrasileira = 207_600_000; // Underline pode ser utilizado em qualquer posição, mas separando os milhares facilita a leitura.
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);
            TestUint();

            // Long (8 bytes): -9_223_372_036_854_775_808 => 9_223_372_036_854_775_807
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);
            TestLong();

            // Ulong (8 bytes): 0 => 18_446_744_073_709_551_615
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);
            TestUlong();

            // Float (4 bytes): -3,402823E+38 => 3,402823E+38
            float precoComputador = 1299.99F; // Precisa colocar o "F" no final para indicar que é um float e não um double, que tem o dobro da capacidade.
            Console.WriteLine("Preço Computador: " + precoComputador);
            TestFloat();

            // Double (8 bytes): -1,79769313486232E+308 => 1,79769313486232E+308
            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor Apple: " + valorDeMercadoDaApple);
            TestDouble();

            // Decimal (16 bytes): -79_228_162_514_264_337_593_543_950_335 => 79_228_162_514_264_337_593_543_950_335
            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas: " + distanciaEntreEstrelas);
            TestDecimal();

            // Char (1 byte)
            char letra = 'b';
            Console.WriteLine("Letra: " + letra);
            TestChar();

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
            TestString();

            #endregion
        }

        #region Tests

        private static void TestBool()
        {
            bool t_bool1 = true;
            bool t_bool2 = false;
            bool t_bool3 = true;

            var a_CompareTo1 = t_bool1.CompareTo(t_bool2); // 1
            var a_CompareTo2 = t_bool1.CompareTo(t_bool3); // 0

            var a_Equals1 = t_bool1.Equals(t_bool2); // false
            var a_Equals2 = t_bool1.Equals(t_bool3); // true

            var a_GetHashCode1 = t_bool1.GetHashCode(); // 1
            var a_GetHashCode2 = t_bool2.GetHashCode(); // 0

            var a_GetType = t_bool1.GetType(); // {Name = "Boolean" FullName = "System.Boolean"}
            var a_GetTypeCode = t_bool1.GetTypeCode(); // Boolean
            var a_ToString = t_bool1.ToString(); // "True"
        }

        private static void TestByte()
        {
            byte t_byte1 = 7;
            byte t_byte2 = 50;
            byte t_byte3 = 7;

            var a_CompareTo1 = t_byte1.CompareTo(t_byte2); // -43
            var a_CompareTo2 = t_byte1.CompareTo(t_byte3); // 0

            var a_Equals1 = t_byte1.Equals(t_byte2); // false
            var a_Equals2 = t_byte1.Equals(t_byte3); // true

            var a_GetHashCode1 = t_byte1.GetHashCode(); // 7
            var a_GetHashCode2 = t_byte2.GetHashCode(); // 50

            var a_GetType = t_byte1.GetType(); // { Name = "Byte" FullName = "System.Byte"}
            var a_GetTypeCode = t_byte1.GetTypeCode(); // Byte
            var a_ToString = t_byte1.ToString(); // "7"
        }

        private static void TestSbyte()
        {
            sbyte t_sbyte1 = 3;
            sbyte t_sbyte2 = 43;
            sbyte t_sbyte3 = 3;
            
            var a_CompareTo1 = t_sbyte1.CompareTo(t_sbyte2); // -40
            var a_CompareTo2 = t_sbyte1.CompareTo(t_sbyte3); // 0

            var a_Equals1 = t_sbyte1.Equals(t_sbyte2); // false
            var a_Equals2 = t_sbyte1.Equals(t_sbyte3); // true

            var a_GetHashCode1 = t_sbyte1.GetHashCode(); // 771
            var a_GetHashCode2 = t_sbyte2.GetHashCode(); // 11051

            var a_GetType = t_sbyte1.GetType(); // { Name = "SByte" FullName = "System.SByte"}
            var a_GetTypeCode = t_sbyte1.GetTypeCode(); // SByte
            var a_ToString = t_sbyte1.ToString(); // "3"
        }
        
        private static void TestShort()
        {
            short t_short1 = 5;
            short t_short2 = 32;
            short t_short3 = 5;

            var a_CompareTo1 = t_short1.CompareTo(t_short2); // -27
            var a_CompareTo2 = t_short1.CompareTo(t_short3); // 0

            var a_Equals1 = t_short1.Equals(t_short2); // false
            var a_Equals2 = t_short1.Equals(t_short3); // true

            var a_GetHashCode1 = t_short1.GetHashCode(); // 327685
            var a_GetHashCode2 = t_short2.GetHashCode(); // 2097184

            var a_GetType = t_short1.GetType(); // {Name = "Int16" FullName = "System.Int16"}
            var a_GetTypeCode = t_short1.GetTypeCode(); // Int16
            var a_ToString = t_short1.ToString(); // "5"
        }

        private static void TestInt()
        {
            int t_int1 = 2;
            int t_int2 = 47;
            int t_int3 = 2;
            int t_int4 = -5;

            var a_CompareTo1 = t_int1.CompareTo(t_int2); // -1
            var a_CompareTo2 = t_int1.CompareTo(t_int3); // 0

            var a_Equals1 = t_int1.Equals(t_int2); // false
            var a_Equals2 = t_int1.Equals(t_int3); // true

            var a_GetHashCode1 = t_int1.GetHashCode(); // 2
            var a_GetHashCode2 = t_int2.GetHashCode(); // 47
            var a_GetHashCode3 = t_int4.GetHashCode(); // -5

            var a_GetType = t_int1.GetType(); // {Name = "Int32" FullName = "System.Int32"}
            var a_GetTypeCode = t_int1.GetTypeCode(); // Int32
            var a_ToString = t_int1.ToString(); // "2"
        }

        private static void TestUint()
        {
            uint t_uint1 = 4;
            uint t_uint2 = 28;
            uint t_uint3 = 4;

            var a_CompareTo1 = t_uint1.CompareTo(t_uint2); // -1
            var a_CompareTo2 = t_uint1.CompareTo(t_uint3); // 0

            var a_Equals1 = t_uint1.Equals(t_uint2); // false
            var a_Equals2 = t_uint1.Equals(t_uint3); // true

            var a_GetHashCode1 = t_uint1.GetHashCode(); // 4
            var a_GetHashCode2 = t_uint2.GetHashCode(); // 28

            var a_GetType = t_uint1.GetType(); // {Name = "UInt32" FullName = "System.UInt32"}
            var a_GetTypeCode = t_uint1.GetTypeCode(); // UInt32
            var a_ToString = t_uint1.ToString(); // "4"
        }

        private static void TestLong()
        {
            long t_long1 = 3;
            long t_long2 = 39;
            long t_long3 = 3;

            var a_CompareTo1 = t_long1.CompareTo(t_long2); // -1
            var a_CompareTo2 = t_long1.CompareTo(t_long3); // 0

            var a_Equals1 = t_long1.Equals(t_long2); // false
            var a_Equals2 = t_long1.Equals(t_long3); // true

            var a_GetHashCode1 = t_long1.GetHashCode(); // 3
            var a_GetHashCode2 = t_long2.GetHashCode(); // 39

            var a_GetType = t_long1.GetType(); // {Name = "Int64" FullName = "System.Int64"}
            var a_GetTypeCode = t_long1.GetTypeCode(); // Int64
            var a_ToString = t_long1.ToString(); // "3"
        }

        private static void TestUlong()
        {
            ulong t_ulong1 = 6;
            ulong t_ulong2 = 24;
            ulong t_ulong3 = 6;

            var a_CompareTo1 = t_ulong1.CompareTo(t_ulong2); // -1
            var a_CompareTo2 = t_ulong1.CompareTo(t_ulong3); // 0

            var a_Equals1 = t_ulong1.Equals(t_ulong2); // false
            var a_Equals2 = t_ulong1.Equals(t_ulong3); // true

            var a_GetHashCode1 = t_ulong1.GetHashCode(); // 6
            var a_GetHashCode2 = t_ulong2.GetHashCode(); // 24

            var a_GetType = t_ulong1.GetType(); // {Name = "UInt64" FullName = "System.UInt64"}
            var a_GetTypeCode = t_ulong1.GetTypeCode(); // UInt64
            var a_ToString = t_ulong1.ToString(); // "6"
        }

        private static void TestFloat()
        {
            float t_float1 = 24f;
            float t_float2 = 35;
            float t_float3 = 24f;

            var a_CompareTo1 = t_float1.CompareTo(t_float2); // -1
            var a_CompareTo2 = t_float1.CompareTo(t_float3); // 0

            var a_Equals1 = t_float1.Equals(t_float2); // false
            var a_Equals2 = t_float1.Equals(t_float3); // true

            var a_GetHashCode1 = t_float1.GetHashCode(); // 1103101952
            var a_GetHashCode2 = t_float2.GetHashCode(); // 1108082688

            var a_GetType = t_float1.GetType(); // {Name = "Single" FullName = "System.Single"}
            var a_GetTypeCode = t_float1.GetTypeCode(); // Single
            var a_ToString = t_float1.ToString(); // "24"
        }

        private static void TestDouble()
        {
            double t_double1 = 5.24;
            double t_double2 = 33.9;
            double t_double3 = 5.24;

            var a_CompareTo1 = t_double1.CompareTo(t_double2); // -1
            var a_CompareTo2 = t_double1.CompareTo(t_double3); // 0

            var a_Equals1 = t_double1.Equals(t_double2); // false
            var a_Equals2 = t_double1.Equals(t_double3); // true

            var a_GetHashCode1 = t_double1.GetHashCode(); // -817308364
            var a_GetHashCode2 = t_double2.GetHashCode(); // 1936965632

            var a_GetType = t_double1.GetType(); // {Name = "Double" FullName = "System.Double"}
            var a_GetTypeCode = t_double1.GetTypeCode(); // Double
            var a_ToString = t_double1.ToString(); // "5,24"
        }

        private static void TestDecimal()
        {
            decimal t_decimal1 = 335_959;
            decimal t_decimal2 = 162_253;
            decimal t_decimal3 = 335_959;

            var a_CompareTo1 = t_decimal1.CompareTo(t_decimal2); // 1
            var a_CompareTo2 = t_decimal1.CompareTo(t_decimal3); // 0

            var a_Equals1 = t_decimal1.Equals(t_decimal2); // false
            var a_Equals2 = t_decimal1.Equals(t_decimal3); // true

            var a_GetHashCode1 = t_decimal1.GetHashCode(); // 1091862876
            var a_GetHashCode2 = t_decimal2.GetHashCode(); // 1090768488

            var a_GetType = t_decimal1.GetType(); // {Name = "Decimal" FullName = "System.Decimal"}
            var a_GetTypeCode = t_decimal1.GetTypeCode(); // Decimal
            var a_ToString = t_decimal1.ToString(); // "335959"
        }

        private static void TestChar()
        {
            char t_char1 = 'L';
            char t_char2 = 'a';
            char t_char3 = 'L';

            var a_CompareTo1 = t_char1.CompareTo(t_char2); // -21
            var a_CompareTo2 = t_char1.CompareTo(t_char3); // 0

            var a_Equals1 = t_char1.Equals(t_char2); // false
            var a_Equals2 = t_char1.Equals(t_char3); // true

            var a_GetHashCode1 = t_char1.GetHashCode(); // 4980812
            var a_GetHashCode2 = t_char2.GetHashCode(); // 6357089

            var a_GetType = t_char1.GetType(); // {Name = "Char" FullName = "System.Char"}
            var a_GetTypeCode = t_char1.GetTypeCode(); // Char
            var a_ToString = t_char1.ToString(); // "L"
        }

        private static void TestString()
        {
            string t_string1 = "Lucas";
            string t_string2 = "Fabi";
            string t_string3 = "Lucas";
            string t_string4 = "   Fabi   ";
            int t_int = 12345;

            var a_Clone = t_string1.Clone();

            var a_CompareTo1 = t_string1.CompareTo(t_string2); // 1
            var a_CompareTo2 = t_string1.CompareTo(t_string3); // 0

            var a_Contains1 = t_string1.Contains("Luc"); // true
            var a_Contains2 = t_string1.Contains("Fab"); // false

            char[] a_CopyTo = { 'N', 'o', 'm', 'e', ':', ' ', 'L', 'u', 'c', 'i', 'a'};

            t_string1.CopyTo(0, a_CopyTo, 6, t_string1.Length); // { 'N', 'o', 'm', 'e', ':', ' ', 'L', 'u', 'c', 'a', 's'}

            var a_EndsWith1 = t_string1.EndsWith('s'); // true
            var a_EndsWith2 = t_string1.EndsWith('i'); // false

            var a_Equals1 = t_string1.Equals(t_string2); // false
            var a_Equals2 = t_string1.Equals(t_string3); // true

            var a_GetEnumerator = t_string1.GetEnumerator();

            var a_GetHashCode1 = t_string1.GetHashCode(); // 71903890
            var a_GetHashCode2 = t_string2.GetHashCode(); // -1446272648

            var a_GetType = t_string1.GetType(); // {Name = "String" FullName = "System.String"}
            var a_GetTypeCode = t_string1.GetTypeCode(); // String

            var a_IndexOf1 = t_string1.IndexOf("cas"); // 2
            var a_IndexOf2 = t_string1.IndexOf("abi"); // -1

            var a_IndexOfAny1 = t_string1.IndexOfAny(new char[] { 'L' }); // 0
            var a_IndexOfAny2 = t_string1.IndexOfAny(new char[] { 'F' }); // -1

            var a_Insert = t_string1.Insert(5, " Barbosa"); // "Lucas Barbosa"

            var a_IsNormalized = t_string1.IsNormalized(); // true

            var a_LastIndexOf1 = t_string1.LastIndexOf("uca"); // 1
            var a_LastIndexOf2 = t_string1.LastIndexOf("abi"); // -1

            var a_LastIndexOfAny1 = t_string1.LastIndexOfAny(new char[] { 'c' }); // 2
            var a_LastIndexOfAny2 = t_string1.LastIndexOfAny(new char[] { 'i' }); // -1

            var a_Length = t_string1.Length; // 5

            var a_Normalize = t_string1.Normalize(); // "Lucas"

            var a_PadLeft = t_string1.PadLeft(10, '!'); // "!!!!!Lucas"
            var a_PadRight = t_string1.PadRight(7, '!'); // "Lucas!!"

            var a_Remove1 = t_string1.Remove(3); // "Luc"
            var a_Remove2 = t_string1.Remove(2, 2); // "Lus"

            var a_Replace1 = t_string1.Replace("cas", "cia"); // "Lucia"
            var a_Replace2 = t_string2.Replace('i', 'y'); // "Faby"

            var a_Split = a_Insert.Split(" "); // { "Lucas" , "Barbosa" }

            var a_StartsWith1 = t_string1.StartsWith("Lu"); // true
            var a_StartsWith2 = t_string1.StartsWith("Fa"); // false

            var a_Substring1 = t_string2.Substring(1); // "abi"
            var a_Substring2 = t_string2.Substring(2, 2); // "bi"

            var a_ToCharArray1 = t_string1.ToCharArray(); // { 'L', 'u', 'c', 'a', 's' }
            var a_ToCharArray2 = t_string1.ToCharArray(1, 3); // { 'u', 'c', 'a' }

            var a_ToLower = t_string1.ToLower(); // "lucas"
            var a_ToLowerInvariant = t_string1.ToLowerInvariant(); // "lucas"

            var a_ToString = t_int.ToString(); // "12345"
            var a_ToUpper = t_string1.ToUpper(); // "LUCAS"
            var a_ToUpperInvariant = t_string1.ToUpperInvariant(); // "LUCAS"
            var a_Trim = t_string4.Trim(); // "Fabi"
            var a_TrimEnd = t_string4.TrimEnd(); // "   Fabi"
            var a_TrimStart = t_string4.TrimStart(); // "Fabi   "
        }

        #endregion
    }
}
