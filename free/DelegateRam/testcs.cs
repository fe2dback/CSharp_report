class Student
{
    public string Name { get; set; }
    public double Score { get; set; }

    public Student(string name, double score)
    {
        this.Name = name;
        this.Score = score;
    }

    public override string ToString()
    {
        return this.Name + ":" + this.Score; 
    }
}

class Students
{
    List<Student> listOfStudent = new List<Student>();


    public delegate void PrintMethod(Student study);

    public void Add(Student student)
    {
        listOfStudent.Add(student);
    }
    

    public void Print()
    {
        Print( (study) =>
        {
            Console.WriteLine(study);
        });
    }

    public void Print(PrintMethod pm)
    {
        foreach (var item in listOfStudent)
        {
            //Console.WriteLine(item.Name + ":" + item.Score);
            pm(item);
        }
    }
}


class testcs
{
    static void Main(string[] args)
    {
        Students students = new Students();
        students.Add(new Student("malsook", 98));
        students.Add(new Student("bongsik", 94));

        students.Print();
        students.Print((study) =>
        {
            Console.WriteLine();
            Console.WriteLine(study.Name);
            Console.WriteLine(study.Score);
        });
    }
}



