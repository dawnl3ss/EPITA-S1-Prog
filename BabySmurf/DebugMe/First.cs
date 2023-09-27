namespace BabySmurf.DebugMe;

public class First
{
    public static double Max(double a, double b, double c, double d)
    {
        if (b < a)
            if (c < a)
                if (d < a)
                    return a;
                else
                    return b;
            else if (c > d)
                return c;
            else
                return d;
        else if (c < b)
            if (d < b)
                return b;
            else
                return c;
        else if (d < c)
            return c;
        else
            return d;
    }
}