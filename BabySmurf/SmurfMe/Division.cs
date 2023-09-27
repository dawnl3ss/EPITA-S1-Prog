namespace BabySmurf.SmurfMe;

public class Division
{
    public static int Remainder(int a, int b)
    {
        if (b != 0)
        {
            int res = a % b;

            if (res < 0)
                if (b <= 0)
                    return res - b;
                else 
                    return res + b;
            else return res;
        }
        else
        {
            Console.Error.Write("Cannot divide by 0");
            return -1;
        }
    }

    public static string Euclidean(int a, int b)
    {
        if (b != 0)
        {
            int r = Remainder(a, b);
            int q = (a - r) / b;
            return a.ToString() + " = " + q.ToString() + " * " + b.ToString() + " + " + r.ToString();
        }
        else
        {
            Console.Error.Write("Cannot divide by 0");
            return "";
        }
        
    }
}