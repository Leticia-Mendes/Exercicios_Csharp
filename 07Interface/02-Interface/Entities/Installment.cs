using System;

namespace _02_Interface.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        
        public override string ToString()
        {
            return DueDate.ToString("yyyy/MM/dd")
                + " - "
                + Amount.ToString("F2");
        }
    }
}
