using System;

namespace Array02Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Entre com o nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("Entre com o preço do produto:");
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Produto{ Nome = nome, Preco = preco }; //ou poderia usar um contrutor
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("A média de preços dos produtos é " + media);
            
        }
    }
}
