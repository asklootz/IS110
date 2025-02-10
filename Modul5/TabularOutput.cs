class TabularOutput // Class for task 5.22
{
    int N { get; set; }

    public TabularOutput()
    {
        // Constructor
    }

    public void PrintTable() // Method to print the table
    {
        Console.WriteLine("Put in the initial value of N: ");
        int newN = Convert.ToInt32(Console.ReadLine()); // Read the initial value of N
        Console.WriteLine("Put in the increment value of N: ");
        int incrementN = Convert.ToInt32(Console.ReadLine()); // Read the increment value of N
        
        Console.WriteLine("\nN\tN^2\tN^3\tN^2 + N^3\n"); // Print the header of the table
        for (int N = newN; N <= incrementN*5; N += incrementN) // Loop to print the table
        {
            Console.WriteLine($"{N}\t{N * N}\t{N * N * N}\t{N * N + N * N * N}"); // Print the table
        }
    }

}