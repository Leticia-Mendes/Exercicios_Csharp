using System;
using System.Globalization;

namespace _07_ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantia = 0;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            ContaBancaria conta = new ContaBancaria(numeroConta, titular);

            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Deseja fazer um depósito? (s/n) ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor do depósito: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(quantia);
                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: " + conta);
            } 

            Console.WriteLine();
            Console.Write("Deseja fazer um saque? (s/n) ");
            resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor do saque: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(quantia);
                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: " + conta);
            } 
            
            Console.WriteLine();
            Console.WriteLine(conta);
        }
    }
}
