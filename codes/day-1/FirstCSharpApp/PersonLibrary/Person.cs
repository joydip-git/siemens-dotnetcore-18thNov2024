namespace PersonLibrary
{
    public class Person
    {
        //can be assigned only through constructor (instance)
        private readonly int id;
        private string name = "";
        private decimal salary;

        //automatic properties
        //property initializer
        public string Location { set; get; } = "";

        public decimal Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        //field initialization
        //private static string companyName = "siemens";

        //can be assigned only through constructor (static)
        public readonly static string companyName;

        public int Id => id;

        public string Name { get => name; set => name = value; }

        //used to initialize ONLY static members
        //executed ONLY once
        //executed before any other ctor
        //can't be parameterized
        //no access specifier is used with it
        static Person()
        {
            companyName = "siemens";
            Console.WriteLine(companyName);
        }

        public Person()
        {

        }
        public Person(int id, string name, decimal salary, string location)
        {
            Console.WriteLine("instance ctor....");
            this.id = id;
            this.name = name;
            this.salary = salary;
            Location = location;
        }

        //public int Id
        //{
        //    //get => id;
        //    //set => id = value;
        //    set { id = value; }
        //    get { return id; }
        //}

        //public int Id
        //{
        //    get => id;
        //}

        //property expression body syntax
        //public int Id => id;

        //method expression body syntax
        //public int GetId() => id;        

        public string GetInformation()
        {
            return $"{this.Id},{this.name},{this.salary}";
        }
    }
}
