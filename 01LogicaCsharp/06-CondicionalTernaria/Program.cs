using System;
using System.Globalization;

namespace _06_CondicionalTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (condição) ? valor_se_verdadeiro : valor_se_falso

            Console.Write("Digite o preço R$");

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.2;
            double total = preco - desconto;

            Console.WriteLine("Desconto: R$" + desconto);
            Console.WriteLine("Total: R$" + total);
        }
    }
}
