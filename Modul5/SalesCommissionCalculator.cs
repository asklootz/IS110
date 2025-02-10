class SalesCommissionCalculator //Class for task 5.19
{
    // Variables for the class
    double itemOne = 239.99;
    double itemTwo = 129.75;
    double itemThree = 99.95;
    double itemFour = 350.89;            
    double commission;
    int i = 0;
    int code = 1;
    public SalesCommissionCalculator()
    {
        // SalesCommissionCalculator constructor
    }

    public void CalculateCommissions() // Method for calculating the commissions
    {
        while (i < 4) // While loop that runs 4 times
        {
            Console.WriteLine($"Enter quantity sold for item {code}: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            switch (code) // Switch statement that checks the item codes and calculates the commission
            {
                case 1: 
                    commission += itemOne * quantity * 0.09;
                    i++;
                    code++;
                    break;
                case 2:
                    commission += itemTwo * quantity * 0.09;
                    i++;
                    code++;
                    break;
                case 3:
                    commission += itemThree * quantity * 0.09;
                    i++;
                    code++;
                    break;
                case 4:
                    commission += itemFour * quantity * 0.09;
                    ++i;
                    code++;
                    break;
                default:
                    Console.WriteLine("Invalid item code");
                    break;
            }
            
            
        }
        Console.WriteLine($"Commission: {commission}"); // Print the commission
        Console.WriteLine($"Total earnings: {commission + 200:C}"); // Print the total earnings
        
    }

}