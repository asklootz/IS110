class Car
{
    public Car()
    {
        // Constructor
    }

    //Variables for the car brand, model and year
    private string brand;
    private string model;
    private string year;

    //Methods to set the car brand, model and year variables
    public void SetBrand(string carBrand)
    {
        brand = carBrand;
    }
    public void SetModel(string carModel)
    {
        model = carModel;
    }
    public void SetYear(string carYear)
    {
        year = carYear;
    }

    //Methods to get the car brand, model and year variables and print them out
    public string GetBrand()
    {
        return brand;
    }
    public string GetModel()
    {
        return model;
    }
    public string GetYear()
    {
        return year;
    }
}

/*
Øvelse 2: 

Henvis til første forelesning når du jobber med denne øvelsen.

Lag en klasse "Bil" og definer "merke", "modell" og "år" som private string instansvariabler. 
Lag set/sett metoder som ikke returnerer noe verdi, men tar parameter som tilsvarer hver instansvariabel. 
Lag hent/get metoder som returnerer verdien til hver instansvariabel. 
I Program.cs lag et objekt av "Bil" klassen, kall sett-metodene (for merke, modell, år) på det objektet og gi verdiene "Mercedes" som "merke", "S-Class" som "modell" og "1998" som "år" til hver sett-metode. 
Kall hent-metodene på objektet for å hente disse verdiene du satt, her skal du definere variabler i Program.cs som beholder de returnerte verdiene fra hent-metodene. 
Da skal du skrive ut verdiene som disse variablene beholder.
*/