namespace _05_Aluno
{
    internal class Aluno
    {
        private string _nome;
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double Nota3 { get; private set; }

        public Aluno(string nome, double nota1, double nota2, double nota3) 
        { 
            _nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }

            }
        }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
    }
}
