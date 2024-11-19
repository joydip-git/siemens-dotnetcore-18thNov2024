// See https://aka.ms/new-console-template for more information
using GenericApp;

Console.WriteLine("Hello, World!");

//new Calculation().Add(12, 13);

//ICalculation<int> calculation = new Calculation<int>();
//calculation.Add(12, 13);

//Calculation<int> calc = (Calculation<int>)calculation;
//calc.Add(13, 14);
//calc.Add<double>(12.34, 34.56);



List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
List<string> people = ["anil", "sunil", "joydip"];

Func<int, bool> evenLogicFn = (num) => num % 2 == 0;
//select num from list where num%2==0

//querying a source of data (LINQ)
//Method query syntax
list
    .Where(evenLogicFn);
    //.ToList();
    //.ForEach(num => Console.WriteLine(num));

//query operator synatx
//num => range variable
var query = from num in list
            where num % 2 == 0
            select num;

query.ToList().ForEach(x => Console.WriteLine(x));

Logic logic = new Logic();
LogicDel<int> evenLogic = new LogicDel<int>(Logic.IsEven);
//Predicate<int> evenLogic = new Predicate<int>(Logic.IsEven);
//Func<int,bool> evenLogic = new Func<int, bool>(Logic.IsEven);

LogicDel<int> oddLogic = new LogicDel<int>(logic.IsOdd);

//LogicDel<int> isGreater = (a) => a > 5;
IEnumerable<int> greaterNumbers = Filter(list, a => a > 5);


IEnumerable<int> evenNumbers = Filter<int>(list, evenLogic);
IEnumerable<int> oddNumbers = Filter(list, oddLogic);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n");
foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}

LogicDel<string> containsDel = new LogicDel<string>(logic.ContainsLetter);
var filteredNames = Filter(people, containsDel);
//foreach (var item in filteredNames)
//{
//    Console.WriteLine(item);
//}
Action<string> printDel = (s) => Console.WriteLine(s);
filteredNames.ToList().ForEach(printDel);

static IEnumerable<TElement> Filter<TElement>(List<TElement> numbers, LogicDel<TElement> logicFn)
{
    List<TElement> list = [];
    foreach (TElement item in numbers)
    {
        if (logicFn(item))
            list.Add(item);
    }
    return list;
}
//static List<TElement> Filter<TElement>(List<TElement> numbers, Predicate<TElement> logicFn)
//{
//    List<TElement> list = [];
//    foreach (TElement item in numbers)
//    {
//        if (logicFn(item))
//            list.Add(item);
//    }
//    return list;
//}

//static List<TElement> Filter<TElement,TResult>(List<TElement> numbers, Func<TElement,TResult> logicFn)
//{
//    List<TElement> list = [];
//    foreach (TElement item in numbers)
//    {
//        if (logicFn(item))
//            list.Add(item);
//    }
//    return list;
//}
class Logic
{
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    public bool IsOdd(int num)
    {
        return num % 2 != 0;
    }
    public bool ContainsLetter(string name)
    {
        return name.Contains('n');
    }
}
delegate bool LogicDel<in TInput>(TInput num);

