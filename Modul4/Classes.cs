class Account // Class for task 4.9
{
    public string name { get; set; } // Auto-implemented property for account name
    private decimal balance; // Instance variable for account balance

    public Account(string accountName, decimal initialBalance) // Constructor that initializes name and balance properties
    {
        name = accountName;
        balance = initialBalance;
    }

    public decimal Balance  // Property to get and set the account balance
    {
        get
        {
            return balance;
        }
        private set
        {
            if (value > 0.0m)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal depositAmount) // Method that deposits only a valid amount
    {
        if (depositAmount > 0.0m)
        {
            balance += depositAmount;
            Console.WriteLine($"Depositing {depositAmount:C} to {name}'s account.");
        }
    }

    public void Withdraw(decimal withdrawAmount) // Method that withdraws only a valid amount
    {
        if (withdrawAmount < balance && withdrawAmount > 0.0m)
        {
            Balance -= withdrawAmount;
            Console.WriteLine($"Withdrawing {withdrawAmount:C} from {name}'s account.");
        }
        else
        {
            Console.WriteLine("Withdrawal amount exceeded account balance! Cannot withdraw.");
        }
    }
}


class Student // Class for task 4.10
{
    // Properties for student ID, name, and grades
    public string id { get; set; }
    public string name { get; set; }
    public decimal mathGrade { get; set; }
    public decimal englishGrade { get; set; }
    public decimal scienceGrade { get; set; }

    public Student(string studentId, string studentName, decimal math, decimal english, decimal science) // Constructor that initializes student properties
    {
        id = studentId;
        name = studentName;
        mathGrade = math;
        englishGrade = english;
        scienceGrade = science;
    }

    public decimal GetAggregate() // Method that calculates the aggregate of the student
    {
        return (mathGrade + englishGrade + scienceGrade);
    }

    public decimal GetPercentage() // Method that calculates the percentage of the student
    {
        return GetAggregate() / 300 * 100;
    }
}


class Asset // Class for task 4.11
{
    // Properties for asset name, value, and depreciation rate
    string name { get; set; }
    decimal value { get; set; }
    decimal depreciationRate { get; set; }

    public Asset(string assetName, decimal assetValue, decimal assetDepreciationRate) // Constructor that initializes asset properties
    {
        name = assetName;
        value = assetValue;
        depreciationRate = assetDepreciationRate;
    }

    public void Depreciate() // Method that depreciates the asset
    {
        value -= value * depreciationRate;
        Console.WriteLine($"\nDepreciating {name} by {depreciationRate:P}. New value is {value:C}");
    }

    public void IncreasedValue(decimal increase) // Method that increases the asset value and then depricates it
    {
        value += increase * value;
        Console.WriteLine($"Increasing {name} by {increase:P}. New value is {value:C}");
        value -= value * depreciationRate;
        Console.WriteLine($"Depreciating {name} by {depreciationRate:P}. New value is {value:C}");
    }
}


class Coaching  // Class for task 4.12
{
    // Properties for coaching type, number of players, class timings, and charges
    string coachingType { get; set; }
    int amountPlayers { get; set; }
    string classTimings { get; set; }
    decimal charges { get; set; }

    public Coaching(string type, int players, string timings, decimal newCharges) // Constructor that initializes coaching properties
    {
        coachingType = type;
        amountPlayers = players;
        classTimings = timings;
        charges = newCharges;
    }

    public void Coachingresults() // Method that displays the coaching results with tabs inbetween
    {
        Console.WriteLine($"Coaching type: {coachingType}\t Number of players: {amountPlayers}\t Timings: {classTimings}\t Charges: {charges}");
    }
}