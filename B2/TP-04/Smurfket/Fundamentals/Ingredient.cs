using System.Diagnostics;

namespace Smurfket.Fundamentals;

public class Ingredient
{
    private IngredientType _type;
    private int _quantity;

    public Ingredient(IngredientType type, int quantity)
    {
        _type = type;
        _quantity = quantity;
    }
    
    public int Price { get => (int)_type; }
    public IngredientType Type { get => _type; }
    public int Quantity { get => _quantity; }

    public bool RemoveQuantity(int quantity)
    {
        if (_quantity - quantity < 0 || quantity < 0)
            return false;
        
        _quantity -= quantity;
        return true;
    }
}