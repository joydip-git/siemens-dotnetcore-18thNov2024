//using System.Collections;
using CollectionsDemo;
using System.Collections.Generic;

List<int> list = new List<int>();
list.Add(1);
list.Insert(0, 2); //<=number of elements currently present
//Console.WriteLine($"Count: {list.Count}");
//Console.WriteLine($"Capacity: {list.Capacity}");
list.Add(10);
list.Add(2);
list.Add(31);

//for (int i = 0; i < list.Count; i++)
//{
//    for (int j = i + 1; j < list.Count; j++)
//    {
//        //if (list[i] > list[j])
//        if (list[i].CompareTo(list[j]) > 0)
//        {
//            int temp = list[i];
//            list[i] = list[j];
//            list[j] = temp;
//        }
//    }
//}
list.Sort();
//Console.WriteLine($"Count: {list.Count}");
//Console.WriteLine($"Capacity: {list.Capacity}");
//list.Remove(1);
//list.RemoveAt(0);
//list.cap

//ArrayList al = new ArrayList();

//object xObj = x;

//al.Add(12);
//al.Add('a');
//al.Add("siemens");

//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}
//foreach(int i in list)
//{
//    Console.WriteLine(i);
//}

MyList<int> myList = new MyList<int>();
myList.Add(10);
myList.Add(1);
//Console.WriteLine($"Count: {myList.Count}");
//Console.WriteLine($"Capacity: {myList.Capacity}");
myList.Add(12);
myList.Add(2);
myList.Add(15);
//Console.WriteLine($"Count: {myList.Count}");
//Console.WriteLine($"Capacity: {myList.Capacity}");
//for (int i = 0; i < myList.Count; i++)
//{
//    Console.WriteLine(myList[i]);
//}
//foreach (int i in myList)
//{
//    Console.WriteLine(i);
//}

//IEnumerator<int> enumerator = myList.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current);
//}



Person myPerson = new Person();
myPerson[1] = 1;
myPerson[2] = "anil";

//Console.WriteLine(myPerson["id"]);
//Console.WriteLine(myPerson["name"]);

Person person = new Person { Id = 2, Name = "abc" };

MyList<Person> people = new MyList<Person> { person, myPerson };
//people.Sort();


List<Person> people1 = new List<Person> { person, myPerson };
//people1.Sort();
//people1.Sort(new PersonComparison(1));
//Comparison<Person> comparison = null;
switch (1)
{
    case 1:
        //comparison = (Person p1, Person p2) => p1.Id.CompareTo(p2.Id);
        people1.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
        break;

    case 2:
        //comparison = (Person p1, Person p2) => p1.Name.CompareTo(p2.Name);
        people1.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
        break;

    default:
        //comparison = (Person p1, Person p2) => p1.Id.CompareTo(p2.Id);
        people1.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
        break;
}
//if (comparison != null)
//{
//    people1.Sort(comparison);
people1.ForEach(person => Console.WriteLine(person.Name + " " + person.Id));
//}
//Comparison<Person> idCompare=(Person p1,Person p2)=>p1.Id.CompareTo(p2.Id);

//Comparison<Person> namCompare = (Person p1, Person p2) => p1.Name.CompareTo(p2.Name);



