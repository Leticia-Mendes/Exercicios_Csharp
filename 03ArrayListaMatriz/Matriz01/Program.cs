using System;

namespace Matriz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz N x N: ");
            Console.Write("Entre com o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com " + n + " valores para a linha " + i + ": ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + "  ");
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total de números negativos:" + count);



        }
    }
}
