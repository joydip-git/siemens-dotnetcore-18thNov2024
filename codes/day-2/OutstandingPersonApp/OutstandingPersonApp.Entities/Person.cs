namespace OutstandingPersonApp.Entities
{
    public class Person
    {
        //public string Name { get; set; }=String.Empty;
        //public required string Name { get; set; }
        public string? Name { get; set; }
        public Person()
        {
            // this.Name = string.Empty;
        }
        public Person(string? name)
        {
            this.Name = name;
        }
        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 10;
            //return Name?.GetHashCode();
        }
        public override string? ToString()
        {
            return Name ?? Name;
            //return Name != null ? Name : null;
        }
    }
}
