namespace SmurfBot.Proficiencies;

public class Smurf
{
    public string Name { get; }
    public int Age { get; }

    public Smurf(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetAge()
    {
        return Age;
    }

    public static Smurf FindPapaSmurf(Smurf[] smurfs)
    {
        int len = smurfs.Length;
        return smurfs[len - 1];
    }
    
    public static bool IsValidSmurf(string name)
    {
        if (name.Length < 7 || !name.EndsWith("Smurf"))
            return false;
        
        string prefix = name.Substring(0, name.Length - 5);
        return !string.IsNullOrEmpty(prefix);
    }
}