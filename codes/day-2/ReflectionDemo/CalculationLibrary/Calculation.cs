namespace CalculationLibrary
{
    public class Calculation : ICalculation
    {
        private int result;
        List<int> results = [];
        public List<int> Results => results;
        public void Add(int x, int y)
        {
            result = x + y;
            results.Add(result);
        }
        public int Subtract(int x, int y)
        {
            result = x - y;
            results.Add(result);
            return result;
        }
    }
}
