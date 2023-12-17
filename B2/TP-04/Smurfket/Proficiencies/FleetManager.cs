namespace Smurfket.Proficiencies;

public class FleetManager
{
    private Queue<Vehicle> _vehiclesQueue;

    public FleetManager()
    {
        _vehiclesQueue = new Queue<Vehicle>();
    }

    public void EnqueueVehicle(Vehicle vehicle)
    {
        _vehiclesQueue.Enqueue(vehicle);
    }

    public Vehicle DequeueVehicle()
    {
        return _vehiclesQueue.Dequeue();
    }

    public string DisplayFleetInfo()
    {
        string str = "";

        foreach (Vehicle vec in _vehiclesQueue)
        {
            if (vec is Car em1)
                str += em1.DisplayCarInfo() + "\n";
            else if (vec is Motorcycle em2)
                str += em2.DisplayMotorcycleInfo() + "\n";
            else if (vec is Truck em3)
                str += em3.DisplayTruckInfo() + "\n";
            else
                str += vec.DisplayInfo() + "\n";
        }

        str = str.Remove(str.Length - 2, 2);
        return str;
    }
}