using System.Reflection;

namespace DelegateDemo
{
    //delegate int CalDel(int a, int b);
    //delegate TResult CalDel<in TInput1, in TInput2,out TResult>(TInput1 a, TInput2 b);

    //class CalDel //: MulticastDelegate//:Delegate:Object
    //{
    //    private MethodInfo _method;
    //    private Object _target;

    //    public MethodInfo Method=>_method;
    //    public Object Target=>_target;

    //    public CalDel(MethodInfo method, Object target)
    //    {
    //        _method = method;
    //        _target = target;
    //    }
    //    public int Invoke(int a, int b)
    //    {
    //        _method.Invoke(_target, [ a, b ]);
    //}

    internal class Calculation
    {
        public static int Add(int a, int y)
        {
            return a + y;
        }
        public int Subtract(int a, int y)
        {
            return a - y;
        }
    }
}
