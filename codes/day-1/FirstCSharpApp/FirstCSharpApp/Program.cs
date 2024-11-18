Console.WriteLine("Hello, World!");

int x = 10;
//Person person1 = new Person(1, "joydip", 1000,"siemens");
//Person person2 = new Person(2, "anil", 2000, "siemens");
//person1.GetInformation();
Person.GetInformation();


Call();
//local function
void Call()
{
    Console.WriteLine("hello world...");
    Console.ReadLine();
}
class Person
{
    private int id;
    private string name = "";
    private decimal salary;
    static string companyName="siemens";

    public Person()
    {

    }
    public Person(int id, string name, decimal salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public static string GetInformation()
    {
        //return $"{this.id},{this.name},{this.salary}";
        return "";
    }
}
