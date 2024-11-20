using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class PersonComparison : IComparer<Person>
    {
        public int SortChoice { get; set; }
        public PersonComparison(int choice)
        {
            SortChoice = choice;
        }
        //externalization of comparison
        public int Compare(Person? x, Person? y)
        {
            if (x == null && y == null) return 0;
            else
            {
                int res = 0;
                switch (SortChoice)
                {
                    case 1:
                        res = x.Id.CompareTo(y.Id);
                        break;
                    case 2:
                        res = x.Name.CompareTo(y.Name);
                        break;
                    default:
                        res = x.Id.CompareTo(y.Id);
                        break;
                }
                return res;
            }
        }
    }
}
