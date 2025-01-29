namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student(); // Creating a new student object

            // Makes user fill in student information
            Console.Write("Enter name: ");
            newStudent.name = Console.ReadLine();
            Console.Write("Enter age: ");
            newStudent.age = int.Parse(Console.ReadLine());
            Console.Write("Enter average grade (1.0 to 6.0): ");
            newStudent.averageGrade  = double.Parse(Console.ReadLine());

            newStudent.WriteInfo(); // Prints out the information about the student

            if (newStudent.DidPass()) // Checks if the student passed or not based on average grade
            {
                Console.WriteLine("Student passed");
            }
            else
            {
                Console.WriteLine("Student failed");
            }

            // Makes user fill in expected grades after X years
            Console.Write("Enter years: ");
            newStudent.years = int.Parse(Console.ReadLine());
            Console.Write("Enter improvement: ");
            newStudent.improvement = double.Parse(Console.ReadLine());

            newStudent.ExpectedGradesAfterXYears(newStudent.improvement); // Calculates the expected average grade after X years with improvement of Y per year and prints it out
            
            if (newStudent.age >= 18 && newStudent.averageGrade >= 5.0) 
            {
                Console.WriteLine($"{newStudent.name} is 18 years or older and has an average grade of 5.0 or higher");
            }
            else if (newStudent.age < 18 || newStudent.name[0] == 'S') // Checks if student is younger than 18 or name starts with 'S'
            {
                Console.WriteLine($"{newStudent.name} is younger than 18 or name starts with 'S'");
            }
        }
    }
}  