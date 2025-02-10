class Account // Class for task 4.9
{
    public string name { get; set; }
    private decimal balance;

    public Account(string accountName, decimal initialBalance)
    {
        name = accountName;
        balance = initialBalance;
    }

    public decimal Balance
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

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            balance += depositAmount;
            Console.WriteLine($"Depositing {depositAmount:C} to {name}'s account.");
        }
    }

    public void Withdraw(decimal withdrawAmount)
    {
        if (withdrawAmount < balance)
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
    public string id { get; set; }
    public string name { get; set; }
    public decimal mathGrade { get; set; }
    public decimal englishGrade { get; set; }
    public decimal scienceGrade { get; set; }

    public Student(string studentId, string studentName, decimal math, decimal english, decimal science)
    {
        id = studentId;
        name = studentName;
        mathGrade = math;
        englishGrade = english;
        scienceGrade = science;
    }

    public decimal GetAggregate()
    {
        return (mathGrade + englishGrade + scienceGrade);
    }

    public decimal GetPercentage()
    {
        return GetAggregate() / 300 * 100;
    }
}


class Asset // Class for task 4.11
{
    string name { get; set; }
    decimal value { get; set; }
    decimal depreciationRate { get; set; }

    public Asset(string assetName, decimal assetValue, decimal assetDepreciationRate)
    {
        name = assetName;
        value = assetValue;
        depreciationRate = assetDepreciationRate;
    }

    public void Depreciate()
    {
        value -= value * depreciationRate;
        Console.WriteLine($"\nDepreciating {name} by {depreciationRate:P}. New value is {value:C}");
    }

    public void IncreasedValue(decimal increase)
    {
        value += increase * value;
        Console.WriteLine($"Increasing {name} by {increase:P}. New value is {value:C}");
        value -= value * depreciationRate;
        Console.WriteLine($"Depreciating {name} by {depreciationRate:P}. New value is {value:C}");
    }
}


class Coaching  // Class for task 4.12
{
    string coachingType { get; set; }
    int amountPlayers { get; set; }
    string classTimings { get; set; }
    decimal charges { get; set; }

    public Coaching(string type, int players, string timings, decimal newCharges)
    {
        coachingType = type;
        amountPlayers = players;
        classTimings = timings;
        charges = newCharges;
    }

    public void Coachingresults()
    {
        Console.WriteLine($"Coaching type: {coachingType}\t Number of players: {amountPlayers}\t Timings: {classTimings}\t Charges: {charges}");
    }
}