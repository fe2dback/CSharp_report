using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class fileus
{
    static void Main(string[] args)
    {
        File.WriteAllText(@"c:\test.txt", "write text");
        Console.WriteLine(File.ReadAllText(@"c:\test.txt"));
       
    }
}