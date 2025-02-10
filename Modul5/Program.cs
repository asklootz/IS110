namespace Modul5
{
    class Program
    {
        static void Main(string []args)
        {

            // a while loop that runs 3 times and checks the inventory of 3 items
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Enter item code: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter starting quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter items purchased: ");
                int purchased = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter items sold: ");
                int sold = Convert.ToInt32(Console.ReadLine());
                InventoryCalculator item = new InventoryCalculator(code, quantity, purchased, sold); // Create an instance of the InventoryCalculator class
                item.CalculateInventory(); // Call the CalculateInventory method
                i++; // Increment the counter
            }

            SalesCommissionCalculator sales = new SalesCommissionCalculator(); // Create an instance of the SalesCommissionCalculator class
            sales.CalculateCommissions(); // Call the CalculateCommissions method
            

            DiscountCalculator newPurchase = new DiscountCalculator(); // Create an instance of the DiscountCalculator class
            newPurchase.CalculateDiscount(); // Call the CalculateDiscount method
            

            LargestNumber number = new LargestNumber(); // Create an instance of the LargestNumber class
            number.FindLargestNumber(); // Call the FindLargestNumber method
            

            TabularOutput newTable = new TabularOutput(); // Create an instance of the TabularOutput class
            newTable.PrintTable(); // Call the PrintTable method


            LargestTwoNumbers twoNumbers = new LargestTwoNumbers(); // Create an instance of the LargestTwoNumbers class
            twoNumbers.FindLargestTwoNumbers(); // Call the FindLargestTwoNumbers method
            

            ValidatingUserInput newUsers = new ValidatingUserInput(); // Create an instance of the ValidatingUserInput class
            newUsers.ValidateInput(); // Call the ValidateInput method
        }
    }
}