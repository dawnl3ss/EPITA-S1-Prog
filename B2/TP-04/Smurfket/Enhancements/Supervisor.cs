namespace Smurfket.Enhancements;

public class Supervisor : Employee
{
    public Supervisor(string name) : base(name) { }

    public string SuperviseWork()
    {
        return Name + " is supervising the work.";
    }

    public string Introduce()
    {
        return "I am " + Name + ", the supervisor.";
    }

}