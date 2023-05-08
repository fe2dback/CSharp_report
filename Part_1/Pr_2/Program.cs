class main
{
    static void Main(string[] args)
    {
        Point dot1 = new Point(5.1f, 8.2f);
        Point dot2 = new Point(6.3f, 5.7f);

        Point dot3 = dot1.Add(dot2);
        dot3.Print();
        Console.WriteLine(dot3);
    }
}
