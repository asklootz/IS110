class Account
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
            Balance += depositAmount;
        }
    }
}