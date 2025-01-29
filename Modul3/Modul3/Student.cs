using System.Threading.Tasks.Dataflow;

class Student
{
    public Student()
    {
        // Constructor
    }

    // Different properties of the students that we want to keep track of
    public string name;
    public int age;
    public double averageGrade;
    public int years;
    public double improvement;
    double newAverageGrade;

    public void WriteInfo() // Prints out all the information about the student that was entered by user
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Average grade: " + averageGrade);
    }
    public bool DidPass() // Checks if the student passed or not based on average grade
    {
        if (averageGrade >= 4.0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ExpectedGradesAfterXYears(double improvement) // Calculates the expected average grade after X years with improvement of Y per year
    {
        newAverageGrade = years * improvement + averageGrade;
        Console.WriteLine($"Expected average grade after {years} years with improvement of {improvement} per year is: {newAverageGrade}");
    }

}


/*
Øvelse 1:
I denne øvelsen skal du lage en Console applikasjon som simulerer administrasjon av en student. Programmet skal ha følgende flyten:

1. Brukeren starter programmet.
2. Konsollen ber brukeren om å skrive inn navn, alder og gjennomsnittskarakter.
3. Programmet skriver ut studentens informasjon.
4. Programmet sjekker om studenten har bestått og gir en melding.
5. Programmet beregner og skriver ut studentens forventede karakter om 2 år.
6. Programmet bruker AND- og OR-operatører for å sjekke spesifikke betingelser og skriver ut meldinger basert på resultatene.

Hva skal du gjøre?

1. Lag en klasse:

Lag en klasse som heter "Student".
Klassen skal ha følgende egenskaper:    
string Navn
int Alder
double Gjennomsnittskarakter
Klassen skal ha følgende metoder:
SkrivInfo(): En metode uten returverdi som skriver ut informasjon om studenten.
HarBestått(): En metode som returnerer "bool" og sjekker om gjennomsnittskarakteren er 4.0 eller høyere (bestått).
2. Lag et objekt av klassen:

I "Program.cs" skal du opprette et objekt av "Student" klassen.
Be brukeren om å oppgi navn, alder og gjennomsnittskarakter, og bruk dette for å fylle ut egenskapene i Student objektet.
3. Skriv kode som:

Bruker metoden "HarBestått()" for å sjekke om studenten har bestått.
Skriver ut en melding til konsollen basert på resultatet.
4. Legg til en funksjon i klassen som heter "ForventetKarakterEtterXÅr(double forbedring)".

Denne skal ta inn et tall som parameter (forventet forbedring per år), legge det til gjennomsnittskarakteren, og returnere resultatet.
Bruk funksjonen i "Program.cs" og skriv ut studentens forventede karakter om 2 år. La oss si at det blir en "1.0" forbedring per år.
5. Lag logikk i "Program.cs" som bruker AND og OR til å sjekke følgende og skriver ut tekst:

Om studenten er 18 år eller eldre "AND" gjennomsnittskarakteren er 5.0 eller høyere.
Skrive ut: "{Navn} er 18 år eller eldre og har en gjennomsnittskarakter på 5.0 eller høyere."
Om studenten er under 18 år "OR" navnet deres starter med bokstaven "S".
Skrive ut: "{Navn} er enten under 18 år eller navnet starter med 'S'."
*/