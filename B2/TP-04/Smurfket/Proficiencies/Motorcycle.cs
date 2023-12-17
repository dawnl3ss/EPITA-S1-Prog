namespace Smurfket.Proficiencies;

public class Motorcycle : Vehicle
{

    private int _numWheels;

    public int NumWheels
    {
        get => _numWheels;
    }

    public Motorcycle(string model, string brand, int year, int numWheels) : base(model, brand, year)
    {
        _numWheels = numWheels;
    }

    public string DisplayMotorcycleInfo()
    {
        return DisplayInfo() + ", Number of wheels: " + NumWheels;
    }
}