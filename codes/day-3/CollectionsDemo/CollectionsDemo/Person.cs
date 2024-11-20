using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        //Indexer
        public object this[int x]
        {
            set
            {
                if (x == 1)
                {
                    Id = (int)value;
                }
                else if (x == 2)
                {
                    Name = (string)value;
                }
            }
            get
            {
                if (x == 1)
                {
                    return Id;
                }
                else if (x == 2)
                {
                    return Name;
                }
                else
                {
                    return "No proper value";
                }
            }
        }

        //Indexer
        public object this[string propName]
        {
            set
            {
                if (propName == "id")
                {
                    Id = (int)value;
                }
                else if (propName == "name")
                {
                    Name = (string)value;
                }
            }
            get
            {
                if (propName == "id")
                {
                    return Id;
                }
                else if (propName == "name")
                {
                    return Name;
                }
                else
                {
                    return "No proper value";
                }
            }
        }

        //internalization of comparison
        public int CompareTo(Person? other)
        {
            if (!ReferenceEquals(this, other))
                return 0;
            else if (this.Id.CompareTo(other.Id) == 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else
                return this.Id.CompareTo(other.Id);
        }
    }
}
