namespace Smurfket.Fundamentals;

public class Shop
{
    private float _balance;
    private List<Potion> _potions;
    private List<Ingredient> _ingredients;
    private List<(int, Ingredient)> _waitingList;

    public Shop()
    {
        _potions = new List<Potion>();
        _ingredients = new List<Ingredient>();
        _waitingList = new List<(int, Ingredient)>();
        _balance = 50;
    }

    public float Balance
    {
        get => _balance;
        set
        {
            if (value > 0)
                _balance = value;
            else
                throw new ArgumentException("caca");
        }
    }

    public bool AddPotion(Potion potion)
    {
        if (potion.CreatePotion(_ingredients))
        {
            _potions.Add(potion);
            return true;
        }

        return false;
    }

    private int IsInStock(PotionType potionType)
    {
        int index = -1 ;
        
        for (int i = 0; i < _potions.Count; i++)
        {
            if ((int)_potions[i].Type == (int)potionType)
            {
                index = i;
            }
        }
        return index;
    }

    public bool SellPotion(PotionType potionType)
    {
        if (IsInStock(potionType) == -1)
            return false;

        foreach (var pot in _potions)
        {
            if ((int)pot.Type == (int)potionType)
            {
                _balance += pot.CalculatePrice();
                _potions.Remove(pot);
                break;
            }
        } 
        return true;
    }

    public void Run(string instruction, string argument)
    {
        
    }
}