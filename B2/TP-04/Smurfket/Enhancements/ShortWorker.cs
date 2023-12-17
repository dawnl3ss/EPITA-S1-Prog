namespace Smurfket.Enhancements;

public class ShortWorker : Employee
{
    public ShortWorker(string name) : base(name){ }

    public string MakeShort()
    {
        return Name + " is making a short.";
    }

    public string Introduce()
    {
        return "I am " + Name + ", a short worker.";
    }

}