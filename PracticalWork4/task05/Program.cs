using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
string[] t = Console.In.ReadToEnd() 
   .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
Student student;
if (t[0] == "DEFAULT") 
{ 
    student = new Student(); 
} 
else 
{ 
    student = new Student(t[1], int.Parse(t[2]));
}
Console.WriteLine(student.GetInfo());
public class Student 
{ 
    public string Name { get; set; } 
    public int Grade { get; set; }

    public Student()
{
    Name = "UNKNOWN";
    Grade = 0;
}

public Student(string name, int grade)
{
    Name = name;
    Grade = grade;
}

public string GetInfo()
{
    return $"{Name} {Grade}";
}
}
