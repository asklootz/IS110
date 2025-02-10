class DiscountCalculator // Class for task 5.20
{
    // Properties, variables for class DiscountCalculator
    double itemPrice  {get; set;}
    double netTotal {get; set;}
    double totalPrice {get; set;}
    public DiscountCalculator()
    {
        // DiscountCalculator constructor
    }
    public void CalculateDiscount() // Method for calculating the discount
    {
        while (true) // While loop that runs until the user decides to stop adding items
        {
            Console.WriteLine("Enter the price of the item:");
            itemPrice = Convert.ToDouble(Console.ReadLine());
            totalPrice += itemPrice;
            Console.WriteLine("Do you want to add another item? (Y/n)");
            string answer = Console.ReadLine();
            if (answer == "n") // If the user decides to stop adding items
            {
                break;
            }
        }
        if (totalPrice <= 5000) // If the total price is less than or equal to 5000 give a 10% discount
        {
            Console.WriteLine("You have got a 10% discount!");
            netTotal = totalPrice - totalPrice * 0.1;
            Console.WriteLine($"Total price: {totalPrice:C}\nNet total that needs to be paid: {netTotal:C}");
        }
        else if (totalPrice > 5000) // If the total price is more than 5000 give a 20% discount
        {
            Console.WriteLine("You have got a 20% discount!");
            netTotal = totalPrice - totalPrice * 0.2;
            Console.WriteLine($"Total price: {totalPrice:C}\nNet total that needs to be paid: {netTotal:C}");
        }
    }
}