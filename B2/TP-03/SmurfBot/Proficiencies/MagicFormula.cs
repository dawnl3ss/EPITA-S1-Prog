namespace SmurfBot.Proficiencies;

public class MagicFormula
{
    public static double CalculateX(Smurf smurf, int population)
    {
        return 0;
    }

    public static double CalculateY(Smurf smurf)
    {
        return 0;
    }

    public static SmurfPoint[] CalculatePoints(Smurf[] smurfs)
    {
        SmurfPoint[] points =
        {
            new SmurfPoint(0, 0)
        };
        return points;
    }

    public static AffineFunction CalculateRegression(SmurfPoint[] points)
    {
        return new AffineFunction(1, 1);
    }

    public static AffineFunction PapaFunction(Smurf smurf, int population)
    {
        return new AffineFunction(1, 1);
    }

    public static SmurfPoint FindVillage(AffineFunction func1, AffineFunction func2)
    {
        return new SmurfPoint(1, 1);
    }

    public static SmurfPoint ApplyFormula(Smurf[] smurfs)
    {
        return new SmurfPoint(1, 1);
    }

}