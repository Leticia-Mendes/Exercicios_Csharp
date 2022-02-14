using System;

namespace _03_Retangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

    }
}
