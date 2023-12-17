namespace Smurfket.Enhancements;

public class HatWorker : Employee
{
    public HatWorker(string name) : base(name) { }

    public string MakeHat()
    {
        return Name + " is making a hat.";
    }

    public string Introduce()
    {
        return "I am " + Name + ", a hat worker.";
    }

}