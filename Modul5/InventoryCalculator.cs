class InventoryCalculator // Class for task 5.18
{
    // Variables for the class
    int itemCode {get; set;}
    int itemStartingQuantity {get; set;}
    int itemsPurchased {get; set;}
    int itemsSold {get; set;}
    public InventoryCalculator(int code, int quantity, int purchased, int sold)
    {
        // InventoryCalculator constructor
        itemCode = code;
        itemStartingQuantity = quantity;
        itemsPurchased = purchased;
        itemsSold = sold;
    }

    public void CalculateInventory() // Method for checking the inventory
    {
        // Method that calculates the inventory
        int endingInventory = itemStartingQuantity + itemsPurchased - itemsSold;
        Console.WriteLine($"Item code: {itemCode}\nEnding inventory: {endingInventory}");
        if (endingInventory/itemStartingQuantity*100 < 1) // If the inventory is less than 1% of the starting quantity
        {
            Console.WriteLine($"Procure more units immidiately!");
        }
    }
}