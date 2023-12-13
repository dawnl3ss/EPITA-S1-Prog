namespace Smurfket.Fundamentals;

public class SmurfEat
{
    public static (int turns, Ingredient ingredient) AskIngredient(IngredientType type)
    {
        return ((int)type / 2, new Ingredient(type, 3));
    }
}