using System;
using System.Globalization;
using System.Collections.Generic;

namespace List02Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funionários serão registrados?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add( new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.Write("Digite o Id do funcionário que irá receber um aumento: ");
            int idAumento = int.Parse(Console.ReadLine());
            
            Funcionario func = list.Find(x => x.Id == idAumento);
            if (func != null)
            {
                Console.Write("Entre com o percentual de aumento %: ");
                double percentualAumento = double.Parse(Console.ReadLine()); 
                func.AumentarSalario(percentualAumento);
            }
            else
            {
                Console.WriteLine("Esse Id não existe.");
            }
            
            Console.WriteLine();
            Console.WriteLine("Lista atualizada:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
