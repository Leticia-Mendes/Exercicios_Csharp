using System;
using System.Globalization;

namespace _03_Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Retangulo retangulo = new Retangulo(largura, altura);

            Console.WriteLine("Area: " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
