namespace Modul4
{
    class Program
    {
        static void Main(string[] args) // Main method
        {
            // Code for task 4.9
            Account account1 = new Account("Jane Green", 50.00m); // Create an Account object
            Account account2 = new Account("John Blue", -7.53m); // Create another Account object

            // Display initial balance of each object
            Console.WriteLine($"{account1.name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.name}'s balance: {account2.Balance:C}");

            // Prompt user for deposit amounts and deposit only valid amounts
            Console.Write($"\nEnter deposit amount for {account1.name}: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account1.Deposit(depositAmount);

            // Prompt user for deposit amounts and deposit only valid amounts
            Console.Write($"\nEnter deposit amount for {account2.name}: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            account2.Deposit(depositAmount);

            // Display new balances
            Console.WriteLine($"\n{account1.name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.name}'s balance: {account2.Balance:C}");

            // Prompt user for withdrawal amounts and withdraw only valid amounts
            Console.Write("\nEnter withdrawal amount for account1: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            account1.Withdraw(withdrawAmount);

            // Prompt user for withdrawal amounts and withdraw only valid amounts
            Console.WriteLine("\nEnter withdrawal amount for account2: ");
            withdrawAmount = decimal.Parse(Console.ReadLine());
            account2.Withdraw(withdrawAmount);
            // Display new balances
            Console.WriteLine($"\n{account1.name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.name}'s balance: {account2.Balance:C}");

            // Code for task 4.10
            Student newStudent = new Student("12345", "John Doe", 90, 21, 50 ); // Create a Student object
            Console.WriteLine($"Student {newStudent.name} has an aggregate of {newStudent.GetAggregate()} and a percentage of {newStudent.GetPercentage()}%"); // Display the student's aggregate and percentage

            // Code for task 4.11
            Asset laptop = new Asset("Laptop", 1000, 0.01m); // Create an Asset object
            laptop.Depreciate(); // Depreciate the asset
            laptop.IncreasedValue(0.05m); // Increase the value of the asset
            Asset phone = new Asset("Phone", 500, 0.02m); // Create another Asset object
            phone.Depreciate(); // Depreciate the asset
            phone.IncreasedValue(0.1m); // Increase the value of the asset

            // Code for task 4.12
            Coaching newCoaching = new Coaching("Football", 20, "10:00", 10.5m); // Create a Coaching object
            newCoaching.Coachingresults(); // Display the coaching results
        }
    }
}