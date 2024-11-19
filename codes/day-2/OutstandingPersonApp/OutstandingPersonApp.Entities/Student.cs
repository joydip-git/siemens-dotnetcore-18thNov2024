namespace OutstandingPersonApp.Entities
{
    public class Student : Person, IOutstanding
    {
        public double Marks { get; set; }
        public Student()
        {

        }
        public Student(string? name,double marks):base(name)
        {
            Marks = marks;
        }
        public bool IsOutstanding() => Marks >= 85;
    }
}
