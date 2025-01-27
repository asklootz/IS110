namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();

            Console.Write("Enter name: ");
            newStudent.name = Console.ReadLine();
            Console.Write("Enter age: ");
            newStudent.age = int.Parse(Console.ReadLine());
            Console.Write("Enter average grade (1.0 to 6.0): ");
            newStudent.averageGrade  = double.Parse(Console.ReadLine());

            newStudent.WriteInfo();

            if (newStudent.DidPass())
            {
                Console.WriteLine("Student passed");
            }
            else
            {
                Console.WriteLine("Student failed");
            }

            Console.Write("Enter years: ");
            newStudent.years = int.Parse(Console.ReadLine());
            Console.Write("Enter improvement: ");
            newStudent.improvement = double.Parse(Console.ReadLine());

            newStudent.ExpectedGradesAfterXYears(newStudent.improvement);
            
            if (newStudent.age >= 18 && newStudent.averageGrade >= 5.0)
            {
                Console.WriteLine($"{newStudent.name} is 18 years or older and has an average grade of 5.0 or higher");
            }
            else if (newStudent.age < 18 || newStudent.name[0] == 'S')
            {
                Console.WriteLine($"{newStudent.name} is younger than 18 or name starts with 'S'");
            }
        }
    }
}