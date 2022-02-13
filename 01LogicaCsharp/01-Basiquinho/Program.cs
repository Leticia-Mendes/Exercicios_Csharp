using System;
using System.Globalization;

namespace ExerciciosCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler dois números inteiros e depois mostrar na tela a soma desses números.
            int n1, n2;

            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos número é " + (n1 + n2));
            Console.WriteLine("-------------------------------");


            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais
            double r, area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio do círculo:");
            r = double.Parse(Console.ReadLine());

            area = pi * r * r;

            Console.WriteLine("A área do círculo é " + area.ToString("F4"));
            Console.WriteLine("-------------------------------");


            //Faça um programa para ler quatro valores inteiros A,B, C, D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D (Diferença = (A*B - C*D).
            int A, B, C, D, dif;

            Console.WriteLine("Digite o valor de A:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D:");
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;
            Console.WriteLine("A diferença entre o produto de A e B e o produto de C e D é " + dif);
            Console.WriteLine("-------------------------------");


            //Faça um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o saláro desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais

            int funcionario;
            double horas, valorHora, salario;

            Console.WriteLine("Digite o numero do funcionário: ");
            funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas que o funcionário " + funcionario + " trabalhou:");
            horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora trabalhada:");
            valorHora = double.Parse(Console.ReadLine());

            salario = horas * valorHora;
            Console.WriteLine("O salário do funcionário " + funcionario + " que trabalhou " + horas + " horas, será de R$" + salario);
            Console.WriteLine("---------------------------------------");


            //Faça um programa para ler o código de uma peça x, o número de peças x, o valor unitário de cada peça x, o código de uma peça y, o número de peças y, o valor unitário de cada peça y. Calcule o mostre o valor a ser pago.
            int peca1, peca2, quantidadePeca1, quantidadePeca2;
            double valorPeca1, valorPeca2, totalPeca1, totalPeca2, valorTotal;

            Console.WriteLine("Digite o código da primeira peça, a quantidade e o valor");
            string[] valores = Console.ReadLine().Split(' ');
            peca1 = int.Parse(valores[0]);
            quantidadePeca1 = int.Parse(valores[1]);
            valorPeca1 = double.Parse(valores[2]);

            Console.WriteLine("Digite o código da segunda peça, a quantidade e o valor");
            valores = Console.ReadLine().Split(' ');
            peca2 = int.Parse(valores[0]);
            quantidadePeca2 = int.Parse(valores[1]);
            valorPeca2 = double.Parse(valores[2]);

            totalPeca1 = quantidadePeca1 * valorPeca1;
            totalPeca2 = quantidadePeca2 * valorPeca2;
            valorTotal = valorPeca1 + valorPeca2;

            Console.WriteLine("Valor de " + quantidadePeca1 + " peças " + peca1 + " R$" + totalPeca1);
            Console.WriteLine("Valor de " + quantidadePeca2 + " peças " + peca2 + " R$" + totalPeca2);
            Console.WriteLine("O valor total é R$" + valorTotal);
            Console.WriteLine("---------------------------------------");


            /*Faça um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
                a área do triangulo retângulo que tem A por base e C por altura
                a área do circulo de raio C (pi = 3,15159)
                a área do trapézio que tem A e B por bases e C por altura
                a area do quadrado que tem lado B
                a area do retangulo que tem lados A e B */

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Digite o valor de A, B e C");
            string[] valor = Console.ReadLine().Split(' ');
            a = double.Parse(valor[0]);
            b = double.Parse(valor[1]);
            c = double.Parse(valor[2]);

            triangulo = a * c / 2.0;
            circulo = 3.14159 * c * c;
            trapezio = (a + b) / 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            
            Console.WriteLine("---------------------------------------");

        }
    }
}
