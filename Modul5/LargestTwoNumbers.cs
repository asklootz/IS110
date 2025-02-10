class LargestTwoNumbers // Class for task 5.23
{
    // Variabels
    private int newNumber;
    private int counter = 10;


    public LargestTwoNumbers()
    {
        // Constructor
    }

    List<int> numbers = new List<int>(); // List to store the numbers

    public void FindLargestTwoNumbers() // Method to find the two largest numbers
    {
        for (int i = 0; i < counter; i++) // Loop to get the numbers
        {
            Console.WriteLine("Enter the next number:"); // Ask the user to enter a number
            newNumber = Convert.ToInt32(Console.ReadLine()); // Read the number from the user
            numbers.Add(newNumber); // Add the number to the list
        }
        numbers.Sort(); // Sort the list
        Console.WriteLine($"The two largest numbers are: {numbers[counter - 1]} and {numbers[counter - 2]}"); // Print the two largest numbers
    }
}