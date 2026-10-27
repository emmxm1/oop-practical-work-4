using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
string[] t = Console.In.ReadToEnd() 
    .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
Person person = new Person(t[0], int.Parse(t[1])); 
int currentYear = int.Parse(t[2]);

int age = person.Age(currentYear);

if (age < 16) 
{ 
    person.ChangeName("VERY_YOUNG");
}
Console.WriteLine($"{person.Name} {age}");
public class Person
 { public string Name { get; set; } 
 public int BirthYear { get; set; }

public Person(string name, int birthYear)
{
    Name = name;
    BirthYear = birthYear;
}

public int Age(int currentYear)
{
    return currentYear - BirthYear;
}

public void ChangeName(string newName)
{
    Name = newName;
}
}
