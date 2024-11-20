Console.WriteLine("Hello, World!");

//CalDel addDel = new CalDel(Calculation.Add);
//CalDel<int, int> addDel = new CalDel<int, int>(Calculation.Add);
//group-method conversion
CalDel<int, int> addDel = Calculation.Add;

Calculation calculation = new();
//CalDel subDel = new CalDel(calculation.Subtract);
//CalDel<long, long> subDel = new CalDel<long, long>(calculation.Subtract);
CalDel<long, long> subDel = calculation.Subtract;

//anonymous method
//CalDel<int, string> multiDel = new CalDel<int, string>(
//    delegate (int a, int b)
//    {
//        return (a * b).ToString();
//    }
//);
//CalDel<int, string> multiDel =
//    delegate (int a, int b)
//    {
//        return (a * b).ToString();
//    };

//Lambda expression => used to represent an anonymous method
//(arg-list) => expression-body;
//(arg-list) => {//code return something;};
CalDel<int, string> multiDel =
    (int a, int b) =>
    {
        return (a * b).ToString();
    };

CalDel<int, float> divDel = (a, b) => b == 0 ? throw new Exception("") : a / b;

CallMethodUsingDelegate(addDel, 12, 3);
CallMethodUsingDelegate(subDel, 190785645, 190785646);
CallMethodUsingDelegate(multiDel, 12, 3);
CallMethodUsingDelegate(divDel, 12, 3);

static void CallMethodUsingDelegate<TInput, TResult>(CalDel<TInput, TResult> cd, TInput x, TInput y)
{
    //callback
    //Console.WriteLine(cd(x, y));
    Console.WriteLine(cd.Invoke(x, y));
}

//delegate int CalDel(int x, int y);
//TInput and TResult => type paramters
delegate TResult CalDel<in TInput, out TResult>(TInput x, TInput y);

class Calculation
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public long Subtract(long x, long y)
    {
        return x - y;
    }
}