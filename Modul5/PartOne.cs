//Variables that may repeat in different parts of the code are named with the task number after it to avoid confusion. (x1, x2, x3, x4, x5, etc.)
//Code for task 5.3 to 5.6
//Commented out code as to not interfere with the rest of the code in Program.cs

/*
// 5.3 - Write four different C# statements that each ass 1 to int variable x
int x3 = 0;
x3++;
++x3;
x3 = x3 + 1;
x3 += 1;
Console.WriteLine(x3); //To check the ways to increment with 1, it should print 4

// 5.4 - Write C# statements to accomplish each of the following tasks
//a) - Assign the sum of x and y to z, and increment x by 1 with ++. Use only one statement and ensure that the original value of x is used in the statement.
int x4 = 5;
int y4 = 4;
int z4 = x4++ + y4; //Adds together x4 and y4, while also incrementing x4 by 1
//b) - Test whether variable count is greater than 10. If it is, display "Count is greater than 10".
int count = 11;
if (count > 10)
{
    Console.WriteLine("Count is greater than 10");
}
//c) - Decrement the variable x by 1, then subtract it from the variable total. Use only one statement.
int total4 = z4;
total4 -= x4--;
Console.WriteLine(total4);
//d) - Calculate the remainder after q is divided by divisor, and assign the result to q. Write this statement in two different ways.
    // q %= divisor
    // q = q % divisor

// 5.5 - Write a C# statement to accomplish each of the following tasks:
//a) - Declare the int variable sum and initialize it to 0.
int sum5 = 0;
//b) - Declare the int variable x and initialize it to 1.
int x5 = 1;
//c) - Add variable x to variable sum, and assign the result to variable sum.
sum5 += x5;
//d) - Display "The sum is: ", followed by the value of variable sum.
Console.WriteLine($"The sum is: {sum5}");

// 5.6 - Combine the statements that you wrote in Exercise 5.5 into a C# app that calculates and displays the sum of the integers from 1 to 10. Use a while statement to loop through the calculation and increment statements. The loop should terminate when the value of x becomes 11.
class Calculate2
{
    static void Calc()
    {
        int sum6 = 0;
        int x6 = 1;

        while (x6 <= 10)
        {
            sum6 += x6;
            x6++;
        }

        Console.WriteLine($"The sum is: {sum6}");
    }
}

*/