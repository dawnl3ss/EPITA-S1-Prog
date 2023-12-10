namespace SmurfBot.Proficiencies;

public class AffineFunction
{
    public double A { get; set; }
    public double B { get; set; }

    public AffineFunction(double a, double b)
    {
        A = a;
        B = b;
    }

    public double GetA()
    {
        return A;
    }

    public double GetB()
    {
        return B;
    }

    public double Evaluate(double x)
    {
        return (A * x) + B;
    }
}