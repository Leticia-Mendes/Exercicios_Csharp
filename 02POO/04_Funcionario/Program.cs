using System;
using System.Globalization;

namespace _04_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Funcionário: " + funcionario);

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salário em qual porcentagem?");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(percentual);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario);

           

        }
    }
}
