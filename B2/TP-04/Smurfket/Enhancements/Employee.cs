namespace Smurfket.Enhancements;

public class Employee : Person
{
    
    public Employee(string name) : base(name){ }

    public string Work()
    {
        return Name + " is working.";
    }

}