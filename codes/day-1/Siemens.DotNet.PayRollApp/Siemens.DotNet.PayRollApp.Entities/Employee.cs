namespace Siemens.DotNet.PayRollApp.Entities
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; set; } = "";
        public decimal BasicPayment { get; set; }
        public decimal DaPayment { get; set; }
        public decimal HraPayment { get; set; }
        public decimal TotalPayment { get; protected set; }

        public Employee()
        {

        }

        public Employee(int id, string name, decimal basicPayment, decimal daPayment, decimal hraPayment)
        {
            Id = id;
            Name = name;
            BasicPayment = basicPayment;
            DaPayment = daPayment;
            HraPayment = hraPayment;
        }
        public virtual void CalculateSalary()
        {
            TotalPayment = BasicPayment + DaPayment + HraPayment;
        }
    }
}
