public delegate int TestDelegateA(int a, int b);

class test
{
    public delegate int TestDelegateB(int a, int b);
    public delegate int TestDelegateC(int a, int b);
    //static void Main(string[] args)
    //{
    //    TestDelegateA delegateA = TestMethod;
    //    TestDelegateB delegateB = delegate (int a, int b) { return a + b; };

    //    TestDelegateC delegateC = (a,b) =>
    //    {
    //        return a + b;
    //    };

    //    delegateA(3, 6);
    //    delegateB(4, 4);
    //    delegateC(5, 6);

    //}

    private static int TestMethod(int a, int b)
    {
        return a + b;
    }
}