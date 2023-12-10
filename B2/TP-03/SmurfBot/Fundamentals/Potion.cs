namespace SmurfBot.Fundamentals;

public class Potion
{

    public int Level;
    private int Quantity { get; set; }

    public Potion(int level, int quantity)
    {
        Level = level;
        Quantity = quantity;
    }

    public bool AddPotion()
    {
        if (Quantity >= 5)
            return false;

        Quantity += 1;
        return true;
    }

    public bool UsePotion()
    {
        if (Quantity <= 0)
            return false;

        Quantity -= 1;
        return true;
    }


    public string DisplayInfo()
    {
        string blank = "";

        if (Quantity > 999)
            blank = "      ";
        else if (Quantity > 99)
            blank = "       ";
        else if (Quantity > 9)
            blank = "        ";
        else
            blank = "         ";

        return blank + Quantity;
    }
}