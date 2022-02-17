using System.Globalization;

namespace List02Funcionario
{
    internal class Funcionario
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Nome: " + Nome + ", Salário: " + Salario.ToString("F2", CultureInfo.InstalledUICulture);
        }
        
        public void AumentarSalario(double percentualAumento)
        {
            Salario += Salario * percentualAumento / 100;
        }
    }
}
