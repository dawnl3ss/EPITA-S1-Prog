namespace Smurfket.Proficiencies;

public class Vehicle
{
    private string _model;
    private string _brand;
    private int _year;

    public Vehicle(string model, string brand, int year)
    {
        _model = model;
        _brand = brand;
        _year = year;
    }

    public string DisplayInfo()
    {
        return "Model: " + _model + ", Brand: " + _brand + ", Year: " + _year;
    }
}