namespace SmurfRecursion;

public class Gargamel
{

    public static string Line(char c, int n)
    {
        if (n < 0)
            throw new ArgumentException("Parameter 'n' should be upper or equal to 0");
        if (n == 0)
            return "";
        else
            return c + Line(c, n - 1);
    }



    private static string ComputeTriangle(char c, int max, int n)
    {
        if (n == max)
            return Line(c, n);
        else
            return Line(c, n) + "\n" + ComputeTriangle(c, max, n + 1);
    }
    public static string Triangle(char c, int n)
    {
        if (n < 0)
            throw new ArgumentException("Parameter 'n' should be positive or 0");
        if (c == '\0')
            return "";
        return ComputeTriangle(c, n, 0);
    }

    public static void Main()
    {
        Console.WriteLine(Triangle('*', 10));
    }
}