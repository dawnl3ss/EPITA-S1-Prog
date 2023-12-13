namespace Smurfket.Fundamentals;

public class CupidPotion : Potion
{
    private static List<Ingredient> _requiredIngredients = new List<Ingredient> ()
    {
        new Ingredient(IngredientType.SPIDEREYE, 4),
        new Ingredient(IngredientType.DEADRAT, 2),
        new Ingredient(IngredientType.SARSAPARILLA, 15)
    };

    public CupidPotion() : base(_requiredIngredients)
    {
        Type = PotionType.CUPID;
    }
}