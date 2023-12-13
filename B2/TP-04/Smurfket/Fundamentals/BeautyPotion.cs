namespace Smurfket.Fundamentals;

public class BeautyPotion : Potion
{
    private static List<Ingredient> _requiredIngredients = new List<Ingredient> ()
    {
        new Ingredient(IngredientType.STRING, 2),
        new Ingredient(IngredientType.DEADRAT, 5),
        new Ingredient(IngredientType.SARSAPARILLA, 1)
    };

    public BeautyPotion() : base(_requiredIngredients)
    {
        Type = PotionType.BEAUTY;
    }
}