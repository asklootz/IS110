class LargestNumber // Class for task 5.21
{
    // Variables for the class
    int counter {get; set;}
    int number {get; set;}
    int largestNumber {get; set;}

    public LargestNumber()
    {
        // LargestNumber constructor
    }

    public void FindLargestNumber() // Method for finding the largest number
    {
        Console.WriteLine("Enter the number of integers you want to compare:");
        counter = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the first number:");
        largestNumber = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < counter; i++)
        {
            Console.WriteLine("Enter the next number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            Console.WriteLine($"The largest number so far is: {largestNumber}");
        }
        Console.WriteLine($"\nThe largest number is: {largestNumber}");
    }


}