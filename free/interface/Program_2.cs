class Program_2
{
    class Student : IComparable
    {
        public int Id;
        public int Score;

        public override string ToString()
        {
            return Id + ":" + Score;
        }

        public int CompareTo(object? obj)
        {
            return ((obj as Student).Score.CompareTo(this.Score));
            //if (this.Score > (obj as Student).Score)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 1;
            //}
        }
    }

    //static  void Main(string[] args)
    //{
    //    List<Student> numbers = new List<Student>()
    //    {
    //        new Student() { Id = 5, Score = 91 },
    //        new Student() { Id = 4, Score = 79 },
    //        new Student() { Id = 3, Score = 85 },
    //        new Student() { Id = 2, Score = 81 },
    //    };
    //    numbers.Sort();

    //    foreach (var i in numbers)
    //    {
    //        Console.WriteLine(i);
    //    }
    //}
}
