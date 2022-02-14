using System;
using System.Globalization;

namespace _04_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do funcionário:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario1 = new Funcionario(nome, salarioBruto, imposto);

            Funcionario funcionario2 = new Funcionario() 
            {
                Nome = "Maria", 
                SalarioBruto = 4000.00, 
                Imposto = 500.00
            };

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionario1);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionario2);


            Console.WriteLine();
            Console.Write($"Deseja aumentar o salário de {funcionario1.Nome} em qual porcentagem? % ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario1.AumentarSalario(percentual);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario1);

           

        }
    }
}
