using System.Threading.Tasks.Dataflow;


class Multiplication
{
    int x, y, z; // Variables for the multiplication
    int sum; // Sum for muliplication

    // Constructor
    public Multiplication()
    {

    }

    // Method for the multiplication
    public void Calculate()
    {
        Console.WriteLine("Enter the first number: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        z = int.Parse(Console.ReadLine());

        sum = x * y * z;

        Console.WriteLine($"The sum of the multiplication is: {sum}");
    }
}