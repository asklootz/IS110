class Calculator
{
    public Calculator()
    {
        // Constructor
    }

    //Variables for the numbers and the results
    private float number1;
    private float number2;
    private float resultAdd, resultSub, resultMul, resultDiv;

    //Methods to set the numbers
    public void SetNumber1()
    {
        Console.WriteLine("Enter first number: ");
        number1 = float.Parse(Console.ReadLine());
        GetNumber1(); // Calls the get method to print out the number
    }
    public void SetNumber2()
    {
        Console.WriteLine("Enter second number: ");
        number2 = float.Parse(Console.ReadLine());
        GetNumber2(); // Calls the get method to print out the number
    }

    //Methods to get the numbers and print them out
    private float GetNumber1()
    {
        Console.WriteLine("First number: " + number1);
        return number1;
    }
    private float GetNumber2()
    {
        Console.WriteLine("Second number: " + number2);
        return number2;
    }

    public void Calculate()
    {
        SetNumber1(); // Calls the set method to set the first number
        SetNumber2(); // Calls the set method to set the second number

        //Calculates the result of the numbers
        resultAdd = number1 + number2;
        resultSub = number1 - number2;
        resultMul = number1 * number2;
        resultDiv = number1 / number2;

        //Prints out the results
        Console.WriteLine($"{number1} + {number2} = {resultAdd}");
        Console.WriteLine($"{number1} - {number2} = {resultSub}");
        Console.WriteLine($"{number1} * {number2} = {resultMul}");
        Console.WriteLine($"{number1} / {number2} = {resultDiv}");
    }
    
}