using System;
using System.Globalization;

namespace _03_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine("A raiz quadrada de " + x + " é " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número:");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");



            // Faça um programa que leia e valide as seguintes informações: nome >= 3 caracteres, Idade entre 0 e 150, e estado civil.

            string nome, estadoCivil;
            double idade, salario;
            Boolean valido = false;

            do
            {
                Console.WriteLine("Escreva seu nome:");
                nome = Console.ReadLine();
                if (nome.Length >= 3)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("nome precisa ter no mínimo 3 caracteres");
                }
            } while (!valido);

            valido = false;
            do
            {
                Console.WriteLine("Digite sua idade: ");
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (idade >= 0 && idade < 150) {
                    valido = true;
                }
                else 
                {
                    Console.WriteLine("Idade precisa ser entre 0 e 150");
                }
            } while (!valido);

            valido = false;
            do 
            {
                Console.WriteLine("Digite o salário");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (salario >= 0)
                {
                    valido = true;
                }
                 else 
                {
                    valido = false;
                }
            } while (!valido);

            valido = false;
            do 
            {
                Console.WriteLine("Selecione o stado civil: C (Casade) - S (Solteire) - D (Divorciade) - V (Viuve)");
                estadoCivil = Console.ReadLine();
                if (estadoCivil.Equals("c",StringComparison.InvariantCultureIgnoreCase) 
                    || estadoCivil.Equals("s",StringComparison.InvariantCultureIgnoreCase)
                    || estadoCivil.Equals("d",StringComparison.InvariantCultureIgnoreCase))
                {
                    valido = true;
                }
                 else 
                {
                    valido = false;
                }
            } while (!valido);

            Console.WriteLine("Nome: " + nome + " idade: " + idade.ToString("F1", CultureInfo.InvariantCulture) + " salario: " + salario.ToString("F2", CultureInfo.InvariantCulture) + " estado civil: " + estadoCivil);
        }
    }
}
