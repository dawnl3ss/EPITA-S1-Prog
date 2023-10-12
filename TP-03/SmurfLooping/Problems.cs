namespace SmurfLooping;

public class Problems
{
    public static string Tree(char c, int n)
    {
        string tree = "";
        int len = n;

        for (int i = 1; i <= n*2; i+=2)
        {
            string line = "";

            for (int j = 1; j <= i; j++)
            {
                line += c;
            }


            for (int j = 1; j <= len - 1; j++)
            {
                line = " " + line;
            }

            tree += line + "\n";
            len--;
        }

        for (int i = 1; i <= 2; i++)
        {
            string line = "";
            
            for (int j = 1; j <= n - 2; j++)
            {
                line = " " + line;
            }

            string chars = "";
            
            for (int j = 1; j <= 3; j++)
            {
                chars += c;
            }
            tree += line + chars;
            if (i != 2) tree += "\n";
        }
        
        return tree;
    }

    public static void Main()
    {
        Console.WriteLine(Tree('+', 5));
    }
}