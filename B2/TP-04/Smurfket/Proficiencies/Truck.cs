namespace Smurfket.Proficiencies;

public class Truck : Vehicle
{

    private int _cargoWeight;

    public Truck(string model, string brand, int year, int cargoWeight) : base(model, brand, year)
    {
        _cargoWeight = cargoWeight;
    }
    
    public int CargoWeight
    {
        get => _cargoWeight;
    }

    public string DisplayTruckInfo()
    {
        return DisplayInfo() + ", Cargo weight: " + CargoWeight;
    }
}