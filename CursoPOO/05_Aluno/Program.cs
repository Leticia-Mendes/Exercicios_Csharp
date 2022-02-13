using System;
using System.Globalization;


namespace _05_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Entre com as informações do aluno:");
            Console.Write("NOME: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("NOTA 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL: " + aluno.NotaFinal().ToString("F2"), CultureInfo.InvariantCulture);

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO.");
                Console.WriteLine("FALTARAM: " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");
            }


        }
    }
}
