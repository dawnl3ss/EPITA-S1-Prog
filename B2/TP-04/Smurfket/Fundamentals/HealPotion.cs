namespace Smurfket.Fundamentals;

public class HealPotion : Potion
{
    private static List<Ingredient> _requiredIngredients = new List<Ingredient>()
    {
        new Ingredient(IngredientType.MUSHROOM, 2),
        new Ingredient(IngredientType.SPIDEREYE, 3),
    };

    public HealPotion() : base(_requiredIngredients)
    {
        Type = PotionType.HEAL;
    }
}