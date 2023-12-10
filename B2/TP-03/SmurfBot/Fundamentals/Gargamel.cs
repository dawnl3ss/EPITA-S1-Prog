namespace SmurfBot.Fundamentals;

public class Gargamel
{
    public int Hp { get; set; }
    public int Attack { get; }

    public Gargamel(int hp, int attack)
    {
        Hp = hp;
        Attack = attack;
    }

    public void AddGargamelHP(int hp)
    {
        Hp += hp;
    }
    
    public string DisplayInfo()
    {
        return "------------ Gargamel ------------\nHP: " + Hp + "         Attack: " + Attack + "\n";
    }
}