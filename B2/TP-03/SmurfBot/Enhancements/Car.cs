namespace SmurfBot.Enhancements;

public class Car
{
    public BatteryState State;


    public Car(int battery)
    {
        State = GetBatteryState(battery);
    }


    public int DistanceMax(int cons)
    {
        if (cons <= 0)
            throw new ArgumentException("Cons must be strictly positive.");

        int maxDistance = 0;

        switch (State)
        {
            case BatteryState.Ultralow:
                maxDistance = 0;
                break;
            case BatteryState.Low:
                maxDistance = 25 / cons;
                break;
            case BatteryState.Medium:
                maxDistance = 50 / cons;
                break;
            case BatteryState.High:
                maxDistance = 75 / cons;
                break;
        }

        return maxDistance;
    }

    
    public int NutsNumber(float dist, int cons)
    {
        return 0;
    }
    
    
    public static int GetBatteryInt(BatteryState state)
    {
        switch (state)
        {
            case BatteryState.Ultralow:
                return 0;
            case BatteryState.Low:
                return 25;
            case BatteryState.Medium:
                return 50;
            case BatteryState.High:
                return 75;
            default:
                return 0;
        }
    }

    public static BatteryState GetBatteryState(int level)
    {
        if (level >= 75)
            return BatteryState.High;
        if (level >= 50 && level < 74)
            return BatteryState.Medium;
        if (level >= 25 && level < 49)
            return BatteryState.Low;
        else
            return BatteryState.Ultralow;
    }
}