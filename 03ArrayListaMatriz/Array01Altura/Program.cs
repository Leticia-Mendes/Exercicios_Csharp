using System;
using System.Globalization;

namespace Array01Altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de alturas a serem lidas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;

            Console.WriteLine("A altura média é " + media.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}
