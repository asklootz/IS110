class Car
{
    public Car()
    {
        // Constructor
    }

    private string brand;
    private string model;
    private string year;

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