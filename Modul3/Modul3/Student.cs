using System.Threading.Tasks.Dataflow;

class Student
{
    public Student()
    {
        // Constructor
    }
    public string name;
    public int age;
    public double averageGrade;
    public int years;
    public double improvement;
    double newAverageGrade;

    public void WriteInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Average grade: " + averageGrade);
    }
    public bool DidPass()
    {
        if (averageGrade >= 4.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ExpectedGradesAfterXYears(double improvement)
    {
        newAverageGrade = years * improvement + averageGrade;
        Console.WriteLine($"Expected average grade after {years} years with improvement of {improvement} per year is: {newAverageGrade}");
    }

}