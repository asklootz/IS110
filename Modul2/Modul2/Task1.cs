using System.Threading.Tasks.Dataflow;


class Multiplication
{
    int x, y, z; // Variables for the multiplication
    int sum; // Sum for muliplication

    // Constructor
    public Multiplication()
    {

    }

    // Method for the multiplication
    public void Calculate()
    {
        Console.WriteLine("Enter the first number: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        z = int.Parse(Console.ReadLine());

        sum = x * y * z;

        Console.WriteLine($"The sum of the multiplication is: {sum}");
    }
}

/*
Øvelse 1:

Skriv en komplett Console applikasjon som utfører hver av følgende oppgaver i Program.cs:
a) Si at en app vil beregne produktet av tre heltall.

b) Erklær variablene x, y, z og resultat til å være av typen int.

c) Be brukeren om å angi det første heltall.

d) Les det første heltallet fra brukeren og lagre det i variabelen x.

e) Be brukeren om å angi det andre heltall.

f) Les det andre heltallet fra brukeren og lagre det i variabelen y.

g) Be brukeren om å angi det tredje heltall.

h) Les det tredje heltallet fra brukeren og lagre det i variabelen z.

i) Beregn multiplikasjon av de tre heltallene i variablene x, y og z, og tilordne resultatet til variabelresultatet.

j) Vis meldingen "Multiplikasjonsresultatet er", etterfulgt av verdien av variabelen resultat, bruk strenginterpolasjon.
*/