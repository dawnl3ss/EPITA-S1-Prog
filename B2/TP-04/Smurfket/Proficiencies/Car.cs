namespace Smurfket.Proficiencies;

public class Car : Vehicle
{
    private int _numDoors;

    public int NumDoors
    {
        get => _numDoors;
    }

    public Car(string model, string brand, int year, int numDoors) : base(model, brand, year)
    {
        _numDoors = numDoors;
    }

    public string DisplayCarInfo()
    {
        return DisplayInfo() + ", Number of doors: " + NumDoors;
    }
}