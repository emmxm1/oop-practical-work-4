using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
string[] t = Console.In.ReadToEnd() 
    .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
Point p = new Point(double.Parse(t[0]), double.Parse(t[1])); 
p.Move(double.Parse(t[2]), double.Parse(t[3]));

Console.WriteLine(p.X); 
Console.WriteLine(p.Y);
public class Point 
{ 
    public double X { get; set; } 
    public double Y { get; set; }


public Point(double x, double y)
{
    X = x;
    Y = y;
}

public void Move(double dx, double dy)
{
    X += dx;
    Y += dy;
}
}
