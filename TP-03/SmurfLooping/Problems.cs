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
    
    public static string KingOfTheHill(string s)
    {
        int len = s.Length;
        string sanitizedStr = "";
        bool hasIncreased = false;
        bool hasDecreased = false;

        // Sanitized str by removing ' '
        foreach (char chr in s)
        {
            if (chr != ' ')
                sanitizedStr += chr;
        }

        for (int i = 1; i <= len; i++)
        {
            if (sanitizedStr[i] > sanitizedStr[i - 1])
                return "non";
        }

        return sanitizedStr;
    }
 
    public static void Main()
    {
        Console.WriteLine(KingOfTheHill("1 2 3 4 3 2 1"));
    }
}