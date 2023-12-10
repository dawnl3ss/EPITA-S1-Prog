namespace SmurfBot.Proficiencies;

public class SmurfPoint
{
    public double X { get; }
    public double Y { get; }

    public SmurfPoint(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double GetX()
    {
        return X;
    }

    public double GetY()
    {
        return Y;
    }
}