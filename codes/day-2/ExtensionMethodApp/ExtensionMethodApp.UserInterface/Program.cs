// See https://aka.ms/new-console-template for more information
using ExtensionMethodApp.CalculationLibrary;
using ExtensionMethodApp.ExtensionLibrary;
using ExtensionMethodApp.SimpleLibrary;

Console.WriteLine("Hello, World!");

Calculation calculation = new Calculation();
Console.WriteLine(calculation.Add(12, 3));
Console.WriteLine(calculation.Subtract(12,3));

SimpleCalculator simpleCalculator = new SimpleCalculator();
Console.WriteLine(simpleCalculator.Multiply(12, 3));
Console.WriteLine(simpleCalculator.Subtract(12, 3));

//Extensions.Subtract(calculation, 12,3);

List<int> list = new List<int>();
Console.WriteLine(list.SayHello("joydip"));
