using OutstandingPersonApp.Entities;
//using static System.Console;

namespace OutstandingPersonApp.UserInterface
{
    static internal class PersonUtility
    {
        public static int GetRecordCount()
        {
            WriteLine("how many records?");
            int count = int.Parse(ReadLine() ?? "2");
            return count;
        }
        public static void PrintChoiceMenu()
        {
            WriteLine("1. Student\n2. Professor");
        }
        public static int GetChoice()
        {
            Write("enter choice[1/2]: ");
            int choice = int.Parse(ReadLine() ?? "1");
            return choice;
        }
        public static Person? Create(int choice)
        {
            Person? person = null;
            Write("Name: ");
            string? name = ReadLine();
            switch (choice)
            {
                case 1:
                    Write("Marks: ");
                    double marks = double.Parse(ReadLine() ?? "0");
                    person = new Student(name, marks);
                    break;

                case 2:
                    Write("Books Published: ");
                    int books = int.Parse(ReadLine() ?? "0");
                    person = new Professor(name, books);
                    break;

                default:
                    break;
            }
            return person;
        }
        public static void SavePersonInStorage(int count, Person?[] people)
        {
            for (int i = 0; i < count; i++)
            {
                PrintChoiceMenu();
                int choice = GetChoice();
                Person? p = Create(choice);
                people[i] = p;
            }
        }
    }
}
