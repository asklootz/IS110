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
        Console.WriteLine("Car brand: " + brand);
        return brand;
    }
    public string GetModel()
    {
        Console.WriteLine("Car model: " + model);
        return model;
    }
    public string GetYear()
    {
        Console.WriteLine("Car year: " + year);
        return year;
    }
}