namespace Siemens.DotNet.PayRollApp.Entities
{
    public class Hr : Employee
    {
        public decimal GratuityPayment { get; set; }

        public Hr() { }

        public Hr(int id, string name, decimal basicPayment, decimal daPayment, decimal hraPayment, decimal gratuityPayment)
            : base(id, name, basicPayment, daPayment, hraPayment)
        {
            GratuityPayment = gratuityPayment;
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            TotalPayment += GratuityPayment;
        }
    }
}
