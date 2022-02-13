using System;
using System.Globalization;

namespace _06_Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cotação Dolar x Real!");
            Console.Write("Qual é a cotação do dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dolares você quer comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.DolarParaReal(dolar, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        
        }
    }
}
