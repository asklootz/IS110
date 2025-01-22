namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Person class
            Person Yeager = new Person();
            // Set the name of the person
            Yeager.Name = "Yeager";

            // Call the Eat and GoShopping methods
            Yeager.Eat();
            Yeager.GoShopping();
        }
    }
}