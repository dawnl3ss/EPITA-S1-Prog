namespace Smurfket.Enhancements;

public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }

    public string IntroducePerson()
    {
        return "I am " + _name + ".";
    }
    
    public string Name
    {
        get => _name;
        set => _name = value;
    }

}