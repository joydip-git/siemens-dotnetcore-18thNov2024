namespace GenericApp
{    
    //generic interface
    interface ICalculation<TElement>
    {
        void Add(TElement a, TElement b);
    }
    //generic class
    internal class Calculation<TElement> : ICalculation<TElement> where TElement : struct
    {
        public void Add(TElement a, TElement b)
        {

        }
        //gneric method
        public void Add<TInput>(TInput a, TInput b) where TInput : struct
        {

        }
    }
}
