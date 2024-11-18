namespace EqualityApp
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Salary { get; set; }

        public Person(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (this == obj) return true;

            if (obj is Person)
            {
                Person p = (Person)obj;
                if (!p.Id.Equals(Id)) return false;
                if (!p.Name.Equals(Name)) return false;
                if (!p.Salary.Equals(Salary)) return false;

                return true;
            }
            else
                return false;
        }
        /*
        public override int GetHashCode()
        {
            const int prime = 31;
            int hash = prime + this.Id;
            hash = hash * prime + this.Name.GetHashCode();
            hash = hash * prime + this.Salary.GetHashCode();
            return hash;
        }

       
        public static bool operator ==(Person a, Person b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Person a, Person b)
        {
            return !a.Equals(b);
        }
        //    public static decimal operator +(Person a, Person b)
        //    {
        //        return a.Salary + b.Salary;
        //    }
        */
        public override string ToString()
        {
            return $"Name={Name}, Id={Id}, Salary={Salary}";
        }
    }
}
