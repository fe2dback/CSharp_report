using System;


class Point
{
    float x_1;
    float y_1;
    Point r_x;
    Point r_y;
    public Point(float x, float y)
    {

        this.x_1 = x;
        this.y_1 = y;
    }

    public Point()
    {

    }

    public Point Add(Point xy)
    {
        Point n = new Point();
        n.x_1 = this.x_1 + xy.x_1;
        n.y_1 = this.y_1 + xy.y_1;
        return n;

    }

    public void Print()
    {
        Console.WriteLine($"{x_1}, {y_1}");
    }

    public override string ToString()
    {
        return $"{x_1}, {y_1}";
    }
}
