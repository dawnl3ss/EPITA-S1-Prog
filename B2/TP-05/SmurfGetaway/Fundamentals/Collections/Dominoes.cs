namespace SmurfGetaway.Fundamentals.Collections;

public class Dominoes
{
    public static List<(int, int)> DominoKit()
    {
        List<(int, int)> l = new List<(int, int)>();

        for (int i = 0; i <= 6; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
                l.Add((i, j));
            }
        }

        return l;
    }

    public static (int, int) RemoveLastDomino(List<(int, int)> dominoes)
    {
        if (dominoes.Count == 0)
            throw new ArgumentException("caca");
        
        (int, int) dom = dominoes[dominoes.Count - 1];
        dominoes.RemoveAt(dominoes.Count - 1);
        return dom;
    }

    public static bool DominoChain(List<(int, int)> dominoes)
    {
        return true;
        //TODO
    }


    public static void Main()
    {
        List<(int, int)> dominoes = new List<(int, int)>();

        (int, int) removed = SmurfGetaway.Fundamentals.Collections.Dominoes.RemoveLastDomino(dominoes);
        foreach (var VARIABLE in dominoes)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}