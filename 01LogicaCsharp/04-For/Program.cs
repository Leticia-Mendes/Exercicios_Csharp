using System;
using System.Globalization;

namespace _04_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1) Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Número #{i} : ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("A soma dos números digitados é: " + soma);
            Console.WriteLine("-----------------------------------------------");



            // Faça um programa que leia um número X e mostre todos os números ímpares de X até 1000.

            Console.Write("2) Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            int impar = 0;
            for (int i = x; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    impar++;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"De {x} até 1000 há {impar} ímpares.");
            Console.WriteLine("-----------------------------------------------");



            // Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações

            Console.Write("3) Quantos números você quer ler? ");
            int N = int.Parse(Console.ReadLine()), nDigitado, intervalo = 0, foraIntervalo = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                nDigitado = int.Parse(Console.ReadLine());
                if (nDigitado >= 10 && nDigitado <= 20)
                {
                    intervalo++;
                }
                else
                {
                    foraIntervalo++;
                }
            }
            Console.WriteLine($"{intervalo} números estão no intervalo 10 - 20.");
            Console.WriteLine($"{foraIntervalo} números estão fora do intervalo.");
            Console.WriteLine("-----------------------------------------------");



            // Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

            Console.Write("4) Quantos testes você quer fazer? ");
            int nVezes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nVezes; i++)
            {
                Console.Write($"{i}ºteste: Digite três números: ");
                string[] valores = Console.ReadLine().Split(' ');
                double num1 = double.Parse(valores[0]);
                double num2 = double.Parse(valores[1]);
                double num3 = double.Parse(valores[2]);

                double mediaPonderada = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
                Console.WriteLine("A média ponderada é  " + mediaPonderada);
            }

            Console.WriteLine("-----------------------------------------------");



            // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            Console.Write("5) Quantas leituras você quer fazer? ");
            int vezes = int.Parse(Console.ReadLine());

            for (int y = 0; y < vezes; y++)
            {
                Console.Write("Digite dois números: ");
                string[] values = Console.ReadLine().Split(' ');
                int n1 = int.Parse(values[0]);
                int n2 = int.Parse(values[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível.");
                }
                else
                {
                    double divisao = (double)n1 / n2;
                    Console.WriteLine("O resultado da divisão é " + divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.WriteLine("-----------------------------------------------");



            // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. Lembrando que, por definição, fatorial de 0 é 1.

            Console.Write("6) Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int a = 1; a <= num; a++)
            {
                fatorial = fatorial * a;
            }

            Console.Write($"O fatorial de {num} é {fatorial} .");
            Console.WriteLine("-----------------------------------------------");



            // Ler um número inteiro N e calcular todos os seus divisores.

            Console.Write("7) Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Os dividendos de {numero} são:");

            for (int b = 1; b < numero; b++)
            {
                if (numero % b == 0)
                {
                    Console.WriteLine(b);
                }
            }

            Console.WriteLine("-----------------------------------------------");

        }
    }
}
