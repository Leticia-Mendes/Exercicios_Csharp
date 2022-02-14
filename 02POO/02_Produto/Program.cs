using System;
using System.Globalization;

namespace _02_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do ptoduto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p1);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);


        }
    }
}
