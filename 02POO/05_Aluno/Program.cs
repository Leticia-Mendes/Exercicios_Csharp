using System;
using System.Globalization;


namespace _05_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as informações do aluno:");
            Console.Write("NOME: ");
            string nome = Console.ReadLine();
            Console.Write("NOTA 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA 3: ");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno1 = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL: " + aluno1.NotaFinal().ToString("F2"), CultureInfo.InvariantCulture);

            if (aluno1.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO.");
                Console.WriteLine("FALTARAM: " + aluno1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");
            }

        }
    }
}
