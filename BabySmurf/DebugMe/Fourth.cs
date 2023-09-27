namespace BabySmurf.DebugMe;

public class Fourth
{
    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }

    public static int TripleMe(int n)
    {
        return n * 3;
    }

    public static int LastDigit(int n)
    {
        return n % 10;
    }

    public static int Mystery(int a, int b)
    {
        if (IsEven(a))
        {
            return a + b / 3;
        }
        else if (IsEven(b))
        {
            return a + LastDigit(TripleMe(b));
        }
        return a + b;
    }

}