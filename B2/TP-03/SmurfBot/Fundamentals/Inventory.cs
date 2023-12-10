namespace SmurfBot.Fundamentals;

public class Inventory
{

    private List<Potion> PotionBag { get; }

    public Inventory(int[] quantities)
    {
        PotionBag = new List<Potion>();

        for (int i = 1; i <= 3; i++)
        {
            PotionBag.Add(new Potion(i, quantities[i - 1]));
        }
    }

    public bool AddPotion(int level)
    {
        if (level < 1 || level > 3)
            throw new ArgumentException("level should be between 1 ans 3");
        
        return PotionBag[level - 1].AddPotion();
    }

    public bool UsePotion(int level)
    {
        if (level < 1 || level > 3)
            throw new ArgumentException("level should be between 1 ans 3");
        
        return PotionBag[level - 1].UsePotion();
    }
    
    public string DisplayInfo()
    {
        string levels = "";
        string numbers = "";

        foreach (var pot in PotionBag)
        {
            levels += "         " + pot.Level;
            numbers += pot.DisplayInfo();
        }

        return "------------ PotionList ------------\nLevel " + levels + "\nNumber" + numbers + "\n";
    }
}