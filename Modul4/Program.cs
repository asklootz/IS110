namespace Modul4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            Console.WriteLine($"{account1.name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.name}'s balance: {account2.Balance:C}");

            Console.Write($"\nEnter deposit amount for {account1.name}: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account1.Deposit(depositAmount);

            Console.Write($"\nEnter deposit amount for {account2.name}: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            account2.Deposit(depositAmount);

            Console.WriteLine($"\n{account1.name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.name}'s balance: {account2.Balance:C}");

            Console.Write("\nEnter withdrawal amount for account1: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            account1.Withdraw(withdrawAmount);

            Console.WriteLine("\nEnter withdrawal amount for account2: ");
            withdrawAmount = decimal.Parse(Console.ReadLine());
            account2.Withdraw(withdrawAmount);

            Console.WriteLine($"\n{account1.name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.name}'s balance: {account2.Balance:C}");


            Student newStudent = new Student("12345", "John Doe", 90, 21, 50 );
            Console.WriteLine($"Student {newStudent.name} has an aggregate of {newStudent.GetAggregate()} and a percentage of {newStudent.GetPercentage()}%");

            Asset laptop = new Asset("Laptop", 1000, 0.01m);
            laptop.Depreciate();
            laptop.IncreasedValue(0.05m);
            Asset phone = new Asset("Phone", 500, 0.02m);
            phone.Depreciate();
            phone.IncreasedValue(0.1m);

            Coaching newCoaching = new Coaching("Football", 20, "10:00", 10.5m);
            newCoaching.Coachingresults();

        }
    }
}