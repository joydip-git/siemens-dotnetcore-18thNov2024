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
List<int> evenNumbers = Filter(list);
foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}

static List<int> Filter(List<int> numbers)
{
    List<int> list = [];
    foreach (var item in numbers)
    {
        if (item % 2 == 0)
            list.Add(item);
    }
    return list;
}

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
}
