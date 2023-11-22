namespace PartySmurf;

public class Bungalow
{
    public static string[] CreateBungalow(string smurf1, string smurf2, string smurf3, string smurf4)
    {
        return new[] { smurf1, smurf2, smurf3, smurf4 };
    }

    public static void Main()
    {
        Console.WriteLine(CreateBungalow("brainy smurf", "hefty smurf", "clumsy smurf", "jokey smurf"));
    }
}