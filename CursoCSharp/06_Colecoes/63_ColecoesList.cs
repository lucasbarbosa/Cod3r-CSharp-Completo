using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            var produto = obj as Produto;
            return produto != null &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            var hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }
    }

    class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);
            
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count); // 4
            carrinho.RemoveAt(3); // Remover índice 3

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count); // 3
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro)); // Último índice: 3

            TesteList();
        }

        #region Tests

        private static void TesteList()
        {
            var produto1 = new Produto("Pai Rico Pai Pobre", 69.9);

            var listaProdutos = new List<Produto> {
                new Produto("Bermuda Palmeiras", 129.9),
                new Produto("Squeeze", 27.9),
                new Produto("Capa Celular", 10)
            };

            var carrinho1 = new List<Produto>();
            Produto[] a_Produto = new Produto[5];

            carrinho1.Add(produto1);
            carrinho1.AddRange(listaProdutos);

            var a_AsReadOnly = carrinho1.AsReadOnly();
            var a_Capacity = carrinho1.Capacity;
            carrinho1.Clear();
            carrinho1.AddRange(listaProdutos);

            var a_Contains = carrinho1.Contains(produto1);
            var a_ConvertAll = carrinho1.ConvertAll(x => x.Preco * 2);
            carrinho1.CopyTo(a_Produto);
            var a_Count = carrinho1.Count;

            carrinho1.ForEach(delegate (Produto p)
            {
                Console.WriteLine(p.Nome);
            });

            var a_GetEnumerator = carrinho1.GetEnumerator();
            var a_GetHashCode = carrinho1.GetHashCode();
            var a_GetRange = carrinho1.GetRange(0, 2);
            var a_GetType = carrinho1.GetType();
            carrinho1.Insert(3, produto1);
            var a_IndexOf = carrinho1.IndexOf(produto1);
            carrinho1.InsertRange(4, listaProdutos);
            var a_LastIndexOf = carrinho1.LastIndexOf(produto1);
            carrinho1.Remove(produto1);
            carrinho1.RemoveAt(4);
            carrinho1.RemoveRange(0, 2);
            carrinho1.Reverse();
            var a_ToArray = carrinho1.ToArray();
            var a_ToString = carrinho1.ToString();
            carrinho1.TrimExcess();

            List<string> nomes = new List<string>
            {
                "Douglas",
                "Adriana",
                "Carlos",
                "Felipe",
                "Bruno"
            };
            nomes.Sort();

            // var a_BinarySearch = carrinho1.BinarySearch();
            // var a_Equals = carrinho1.Equals();
            // var a_Exists = carrinho1.Exists();
            // var a_Find = carrinho1.Find();
            // var a_FindAll = carrinho1.FindAll();
            // var a_FindIndex = carrinho1.FindIndex();
            // var a_FindLast = carrinho1.FindLast();
            // var a_FindLastIndex = carrinho1.FindLastIndex();
            // carrinho1.RemoveAll();
            // var a_TrueForAll = carrinho1.TrueForAll();
        }

        #endregion
    }
}
