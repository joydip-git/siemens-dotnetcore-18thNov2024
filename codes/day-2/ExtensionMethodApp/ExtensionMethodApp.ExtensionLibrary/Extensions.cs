//using ExtensionMethodApp.CalculationLibrary;
//using ExtensionMethodApp.SimpleLibrary;
using ExtensionMethodApp.CalculationLibrary;
using ExtensionMethodApp.CalculatorContractLibrary;

namespace ExtensionMethodApp.ExtensionLibrary
{
    public static class Extensions
    {
        public static int Subtract(this ICalculator calc, int a, int b)
        {
            return a - b;
        }

        public static string SayHello<T>(this IEnumerable<T> collection, string message)
        {
            return "Hello " + message;
        }
        //public static int Subtract(this Calculation calc, int a, int b)
        //{            
        //    return a - b;
        //}
        //public static int Subtract(this SimpleCalculator calc, int a, int b)
        //{
        //    return a - b;
        //}
    }
}
