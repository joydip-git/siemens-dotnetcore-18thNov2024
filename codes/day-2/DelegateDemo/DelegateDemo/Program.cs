using DelegateDemo;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

Calculation calculation = new();
//CalDel subDel = new CalDel(calculation.Subtract);
//CalDel<int, int> subDel = new CalDel<int, int>(calculation.Subtract);

Func<int, int, int> subDel = new Func<int, int, int>(calculation.Subtract);
//calculation.GetType().GetMethod("Subtract");

//CalDel addDel = new(Calculation.Add);
//CalDel<int, int,int> addDel = new CalDel<int, int,int>(Calculation.Add);
Func<int, int, int> addDel = new Func<int, int, int>(Calculation.Add);
//typeof(Calculation).GetMethod("Add");

Console.WriteLine(subDel.Invoke(12, 3));
Console.WriteLine(addDel(12, 3));

Console.WriteLine(subDel.Target != null ? subDel.Target.GetType().Name : "No Ref");
Console.WriteLine(subDel.Method.Name);

Console.WriteLine(addDel.Target != null ? addDel.Target.GetType().Name : "No Ref");
Console.WriteLine(addDel.Method.Name);

//anonymous method => delegate (int a, int b) { return a * b; }
//anonymous delegate => a delagate referring an anonymous method
Func<int, int, int> multiDel = delegate (int a, int b) { return a * b; };
Console.WriteLine(multiDel(12, 3));

//Lambda expression: a syntax to write anonymous method
//Func<int, int, int> divDel = (int a, int b) => { return a / b; };

//Type inference
Func<int, int, int> divDel = (a, b) => b == 0 ? throw new ArgumentException("divisor should not be zero") : a / b;