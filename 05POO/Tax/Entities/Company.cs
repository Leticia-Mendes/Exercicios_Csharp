using System;

namespace Tax.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int employes)
            : base(name, anualIncome)
        {
            Employees = employes;
        }

        public override double Tax()
        {
            if (Employees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
