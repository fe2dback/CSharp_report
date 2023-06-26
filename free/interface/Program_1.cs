interface ICallable
{
    void Call();
} 

class AndroidPhone : ICallable
{
    public void Call()
    {
        Console.WriteLine("Android Call");
    }
}

class ApplePhone : ICallable
{
    public void Call()
    {
        Console.WriteLine("Apple Call");
    }
}

class PayPhone : ICallable
{
    public void Call()
    {
        Console.WriteLine("Pay Call");
    }
}

class Program_1
{
    /*
    static void Main(string[] args)
    {
        List<ICallable> phoneList = new List<ICallable>();

        ICallable and = new AndroidPhone();
        ICallable app = new ApplePhone();
        ICallable pay = new PayPhone();

        phoneList.Add(and);
        phoneList.Add(app);
        phoneList.Add(pay);

        foreach (ICallable ic in phoneList)
        { 
            ic.Call();
        }
    }
    */
}


