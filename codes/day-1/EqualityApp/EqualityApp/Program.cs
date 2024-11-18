namespace EqualityApp
{
    internal class Program
    {
        //static HashSet<Person> people = new HashSet<Person>();
        static void Main()
        {
            Person anilPerson = new Person(1, "anil", 1000);
            Person sunilPerson = new Person(1, "anil", 1000);

            HashSet<Person> people = new HashSet<Person>();
            people.Add(anilPerson);
            people.Add(sunilPerson);

            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
            }

            //Console.WriteLine(anilPerson + sunilPerson);

            //if (anilPerson.Equals(sunilPerson))

            if (anilPerson.GetHashCode() == sunilPerson.GetHashCode())
            {
                Console.WriteLine("same");
            }
            else
                Console.WriteLine("not same");
            
            if (anilPerson == sunilPerson)
                Console.WriteLine("same");
            else
                Console.WriteLine("not same");
        }       
    }
}
