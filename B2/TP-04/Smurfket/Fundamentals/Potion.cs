namespace Smurfket.Fundamentals;

public class Potion
{
    private float _price;
    private List<Ingredient> _requiredIngredients;
    private PotionType _type;
    private int _level;

    protected Potion(List<Ingredient> requiredIngredients)
    {
        _type = PotionType.HEAL;
        _requiredIngredients = requiredIngredients;
        _price = 10;
        foreach (var ing in requiredIngredients)
        {
            _price += ing.Price * 1.2f * ing.Quantity;
        }
    }

    protected float Price { get => _price; }
    public int Level { get => _level; set => _level = value; }
    public PotionType Type { get => _type; set => _type = value; }

    public float CalculatePrice()
    {
        return float.Round(_price * (int)_type, 2);
    }

    public bool CreatePotion(List<Ingredient> inventory)
    {
        List<bool> has = new List<bool>();
        int i = 0;
        
        foreach (var ing in _requiredIngredients)
        {
            has.Insert(i,false);

            foreach (var inginv in inventory)
            {
                if (ing.Type == inginv.Type && ing.Quantity >= inginv.Quantity)
                {
                    has[i] = ing.RemoveQuantity(inginv.Quantity);
                }
            }
            i++;
        }
        return !has.Contains(false);
    }

    public bool UpgradePotion(float balance)
    {
        if (balance >= (CalculatePrice() * 69) / 42)
        {
            _level += 1;
            _price *= 2;
            return true;
        }

        return false;
    }
}