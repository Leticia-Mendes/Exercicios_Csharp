using System;
using System.Globalization;

namespace _02_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();

            Console.WriteLine("Entre com os dados do ptoduto: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do Produto: " + p1);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
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
