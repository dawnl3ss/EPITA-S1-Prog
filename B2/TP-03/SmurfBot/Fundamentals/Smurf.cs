namespace SmurfBot.Fundamentals;

public class Smurf
{
    private string Name { get; }
    public int Hp { get; private set; }
    public int Alchemy { get; }
    public int Strength{ get; set; }

    public Smurf(string name, int hp, int alchemy, int strength)
    {
        Name = name;
        Hp = hp;
        Alchemy = alchemy;
        Strength = strength;
    }

    public void AddSmurfHP(int hp)
    {
        Hp += hp;
    }

    public void AddSmurfStrength(int strength)
    {
        Strength += strength;
    }

    public string DisplayInfo()
    {
        return "------------ Smurf: " + Name + " ------------\nHP: " + Hp + "         Alchemy: " + Alchemy + "     Strength: " + Strength + "\n";
    }
}