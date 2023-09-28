namespace BabySmurf.DebugMe;

public class Second
{
    public static int Floor(double n)
    {
        if (n > 0)
        {
            return (int) n;
        }
        else if (n < 0)
        {
            if (n - (int)n != 0)
            {
                return (int)n - 1;
            }
            else return (int)n;
            
        }
        else return (int) n;
    }
}