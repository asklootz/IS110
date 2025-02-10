class ValidatingUserInput // Class for task 5.24
{
    // Variables
    int passes {get; set;}
    int failures {get; set;}
    int studentCounter = 1;

    public ValidatingUserInput()
    {
        // Constructor
    }

    public void ValidateInput() // Method to validate user input
    {
        while (studentCounter <= 10) // Loop to get the results of 10 students
        {
            Console.WriteLine("Enter result (1 = pass, 2 = fail): "); // Ask the user to enter the result
            int result = Convert.ToInt32(Console.ReadLine()); // Read the result from the user
            if (result == 1 || result == 2) // Check if the result is valid
            {
                if (result == 1) // Check if the student passed
                {
                    passes++;
                }
                else // Check if the student failed
                {
                    failures++;
                }
                studentCounter++; // Increment the counter
            }
            else // If the result is invalid
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2."); // Print an error message
            }
        }
        Console.WriteLine($"Passed: {passes}\nFailed: {failures}"); // Print the number of passes and failures
        if (passes > 8) // Check if more than 8 students passed
        {
            Console.WriteLine("Bonus to instructor!"); // Print a bonus message
        }
    }


}