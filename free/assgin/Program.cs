interface Image
{
    void Image();

}

interface Contents
{
    void Contents();
}

interface Title
{
    void Title();
}

class image
{
    public int width = 0;
    public int height = 0;
    public int px;
    public string name = "";
    public delegate int Set_px(int a, int b);
    public delegate int Set_resol(int a);
    public int img_px()
    {
        Set_px px = (a, b) =>
        {
            return a*b;
        };

        return px(this.height, this.width);
    }

    public string img_resol()
    {
        switch (this.height)
        {
            case 720:
                return "HD";
                break;
            case 1080:
                return "FHD";
                break;
            case 1440:
                break;
                return "QHD";
            case 2160:
                break;
                return "UHD";
                break;
            default:
                return "unknown";
                break;
        }
        return "unknown";


    }

}


class post : Title, Contents, Image
{
    string title = "";
    image image = new image();
    string contents = "";


    public void Upload()
    {

        Title();
        Image();
        Contents();
        Console.Clear();


        Console.WriteLine(this.title + "\n\n");
        //image gen
        //for(int i = 0; i < image.height; i++)
        //{         
        //    for(int j = 0; j < image.width; j++)
        //    {
        //        Console.Write("□");

        //    }
        //    Console.WriteLine();
        //}
        Console.WriteLine(image.name + "." + image.img_px() + "px." + "("+image.img_resol()+")\n\n");
        Console.WriteLine(this.contents);
    }


    public void Contents()
    {
        Console.WriteLine("Write Contents");
        this.contents = Console.ReadLine();
    }

    public void Image()
    {
        Console.Write("img.W : ");
        image.width = int.Parse(Console.ReadLine());
        Console.Write("img.H : ");
        image.height = int.Parse(Console.ReadLine());
        Console.Write("img.Name : ");
        image.name = Console.ReadLine();
        image.px = image.height * image.width;
    }

    public void Title()
    {
        Console.WriteLine("Write Title");
        this.title = Console.ReadLine();
    }


}

class DirectMessage : Contents
{

    public void selete_member()
    {
        
    }
    public void Contents()
    {
        Console.Write("Write Send Message : ");
        string message = Console.ReadLine();
    }
}


class Program
{
    static void Main(string[] args)
    {
        post p = new post();
        p.Upload();
    }
}

