using System.Globalization;

namespace _04_Funcionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public Funcionario() {}

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentual)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * percentual / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", salário líquido: R$" 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
