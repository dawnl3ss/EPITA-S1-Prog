namespace BabySmurf.DebugMe;

public class First
{
    public static double Max(double a, double b, double c, double d)
    {
        double max = a;

        if (b > max)
            max = b;
        
        if (c > max)
            max = c;
        
        if (d > max)
            max = d;
        
        return max;
    }
}