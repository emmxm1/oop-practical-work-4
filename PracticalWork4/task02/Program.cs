using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

string[] t = Console.In.ReadToEnd() 
    .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
Car car = new Car(t[0], t[1], double.Parse(t[2])); 
car.ChangePrice(double.Parse(t[3])); 
Console.WriteLine(car.GetInfo());
public class Car 
{ public const string BrandName = "AUDI";

public string Model { get; set; }
public string Color { get; set; }
public double Price { get; set; }

public Car(string model, string color, double price)
{
    Model = model;
    Color = color;
    Price = price;
}

public void ChangePrice(double percent)
{
    Price = Price * (100 + percent) / 100;
}

public string GetInfo()
{
    return $"{BrandName} {Model} {Color} {Price}";
}
}