using ExtensionMethodApp.CalculatorContractLibrary;

namespace ExtensionMethodApp.SimpleLibrary
{
    public class SimpleCalculator:ICalculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
