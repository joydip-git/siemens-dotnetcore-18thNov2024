using PersonLibrary;

Console.WriteLine("Hello, World!");

Call();
//local function
void Call()
{
    Console.WriteLine("hello world...");
    Console.ReadLine();
}

Person anilPerson = new(1, "joydip", 1000);
Person sunilPerson = new(2, "sunil", 2000);
//Console.WriteLine(anilPerson.GetInformation());
//Console.WriteLine(Person.companyName);
