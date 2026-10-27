using System.Globalization;


string[] t = Console.In.ReadToEnd()
    .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);



string model = t[0];
string color = t[1];
double price = double.Parse(t[2], CultureInfo.InvariantCulture);



Car car = new Car(model, color, price);
Console.WriteLine(car.GetInfo());



public class Car
{
    public const string BrandName = "AUDI";



    public string Model { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }



    public Car(string model, string color, double price)
    {
        Model = model;
        Color = color;
        Price = price;
    }

    public string GetInfo()
    {
        return $"{BrandName} {Model} {Color} {Price}";
    }
}