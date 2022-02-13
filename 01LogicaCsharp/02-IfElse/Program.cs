using System;
using System.Globalization;

namespace _02_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(" O número digitado é zero");
            } 
            else if (n >= 1)
            {
                Console.WriteLine(n + " é um número positivo");
            } else { Console.WriteLine(n + " é um número negativo"); }
            
            Console.WriteLine("--------------------------------------");



            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Console.WriteLine("Digite um número:");
            int p = int.Parse(Console.ReadLine());

            if (p % 2 == 0)
            {
                Console.WriteLine(" O número " + p + " é par");
            }
            else { Console.WriteLine("O número " + p + " é impar"); }

            Console.WriteLine("--------------------------------------");



            // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

            Console.WriteLine("Digite dois números inteiros A e B:");
            string[] values = Console.ReadLine().Split(' ');
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);

            if ((A % B == 0) || (B % A == 0)) 
            {
                Console.WriteLine($"Os númers {A} e {B} são múltiplos");
            } 
            else 
            {
                Console.WriteLine($"Os números {A} e {B} não são múltiplos");
            }

            Console.WriteLine("-----------------------------------------------");



            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            Console.WriteLine("Digite a hora do início do jogo: ");
            double horaInicio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora do fim do jogo: ");
            double horaFim = double.Parse(Console.ReadLine());

            double duracao;
            if (horaInicio < horaFim)
            {
                duracao = horaFim - horaInicio;
            }
            else
            {
                duracao = 24 - horaInicio + horaFim;
            }

            Console.WriteLine($"O jogo durou {duracao} horas.");

            Console.WriteLine("-----------------------------------------------");



            // Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

            Console.WriteLine("Digite o código e a quantidade do item:");
            Console.WriteLine("1    Cachorro quente     R$4,00");
            Console.WriteLine("2    X-Salada            R$4,50");
            Console.WriteLine("3    Batata frita        R$2,50");
            Console.WriteLine("4    Refrigerante        R$2,00");
            
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            double quantidade = double.Parse(valores[1]);

            double total = 0;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 2.5;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                Console.WriteLine("Codigo inválido");
            }

            Console.WriteLine("Total: R$" + total.ToString("F2"));

            Console.WriteLine("-------------------------------------------------");



            // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num <= 25 )
            {
                Console.WriteLine("Intervalo 0 - 25");
            } 
            else if (num > 25 && num <= 50)
            {
                Console.WriteLine("Intervalo 25 - 50");
            } 
            else if (num > 50 && num <= 75)
            {
                Console.WriteLine("Intervalo 50 - 75");
            } 
            else if (num > 75 && num <= 100)
            {
                Console.WriteLine("Intevalo 75 - 100");
            } 
            else
            {
                Console.WriteLine("Número fora do intervalo");
            }

            Console.WriteLine("-----------------------------------------------");



            // Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0) Se o ponto estiver na origem, escreva a mensagem “Origem” Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

            Console.WriteLine("Digite dois valores decimais x e y:");
            string[] eixo = Console.ReadLine().Split(' ');
            double x = double.Parse(eixo[0]);
            double y = double.Parse(eixo[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Quadrante 1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Quadrante 2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Quadrante 3");
            }
            else
            {
                Console.WriteLine("Quadrante 4");
            }

            Console.WriteLine("-----------------------------------------------");



            // Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda.

            Console.WriteLine("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int percentual;
            double imposto;

            if (salario <= 2000) {
                percentual = 0;
                Console.WriteLine("Isento de imposto");
            }
            else if (salario <= 6000)
            {
                percentual = 8;
            }
            else if (salario <= 12000)
            {
                percentual = 12;
            }
            else
            {
                percentual = 16;
            }

            imposto = ((salario - 2000) / 100) * percentual;

            Console.WriteLine($"Salario: {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pecentual de IR: {percentual}%");
            Console.WriteLine($"Imposto de renda: {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-----------------------------------------------");



            //Programa que mostre o maior de 3 números com uma função.

            Console.WriteLine("Digite três números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3= int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);


        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c && b > a)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }



    }
}
