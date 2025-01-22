
public class Person
{
    // Instance variables, private so that they are only visible to the class methods
    private string? name;
    private string? shoppingList;

    public string? Name { get; set; }

    // Constructor
    public Person()
    {
        name = "";
        shoppingList = "";
    }
    // Methods for using the newmly made object using the name given in the main method

    //Method for eating and printing a string with interpolated string
    public void Eat()
    {
        string food = "Pizza";
        Console.WriteLine($"{Name} is eating {food}");
    }

    //Method for going shopping and printing a string with interpolated string
    public void GoShopping()
    {
        shoppingList = "Milk, Eggs, Bread, Cheese";
        Console.WriteLine($"{Name} is going shopping for {shoppingList}");
    }
}
