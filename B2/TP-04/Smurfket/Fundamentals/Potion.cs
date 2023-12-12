namespace Smurfket.Fundamentals;

public class Potion
{
    private float _price;
    private List<Ingredient> _requiredIngredients;
    private PotionType _type;
    private int _level;

    protected Potion(List<Ingredient> requiredIngredients)
    {
        _price = 10;
        foreach (var ing in requiredIngredients) { _price += ing.Price * 1.2f * ing.Quantity; }
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
        
    }
    
    public static void Main()
    {
        
    }
}