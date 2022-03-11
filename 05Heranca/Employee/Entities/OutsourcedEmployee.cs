namespace PaymentEmployee.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdicionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double adicionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdicionalCharge = adicionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdicionalCharge;
        }
    }
}
