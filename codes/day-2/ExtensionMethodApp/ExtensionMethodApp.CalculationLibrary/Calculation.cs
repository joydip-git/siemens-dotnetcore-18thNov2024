using ExtensionMethodApp.CalculatorContractLibrary;

namespace ExtensionMethodApp.CalculationLibrary
{
    public class Calculation:ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
