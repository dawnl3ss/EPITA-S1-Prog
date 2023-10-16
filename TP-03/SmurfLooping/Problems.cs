namespace SmurfLooping;

public class Problems
{
    public static string Tree(char c, int n)
    {
        if (n < 4)
            throw new ArgumentException("Parameter 'n' must be upper than 3.");
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
    
    public static int KingOfTheHill(string s)
    {
        int king = -1;
        int previous = -1;
        bool increasing = false;
        bool decreasing = false;

        foreach (char digit in s)
        {
            if (digit == ' ')
                continue;
            
            int current = digit - '0';

            if (previous == -1)
            {
                previous = current;
                king = current;
            }
            else if (current > previous)
            {
                if (decreasing)
                    return -1;
                
                increasing = true;
                king = current;
                previous = current;
            }
            else if (current < previous)
            {
                decreasing = true;
                previous = current;
            }
            else if (current == previous)
            {
                king = current;
            }
        }

        return king;
    }

    public static string ItoA(int n)
    {
        if (n == 0)
            return "0";
        
        string result = "";
        int nn = Int32.Abs(n);
        
        while (nn > 0) 
        {
            result = (Int32.Abs(nn) % 10) + result;
            nn /= 10;
        }
        
        if (n < 0)
            result = "-" + result;
        
        return result;
    }

    public static int AtoI(string s)
    {
        int result = 0;
        
        foreach (char chr in s)
        {
            if (chr == ' ' || chr == ',' || chr == '!' || chr == '?' || chr == ':' || chr == '.' || chr == '*')
                throw new ArgumentException("Parameter 's' could not contain special characters.");

            if (chr == '+' || chr == '-')
                continue;
            
            result = result * 10 + (chr - '0');
        }

        if (s[0] == '-')
            result = -result;
        
        return result;
    }


    public static string DecimalToBase16(ushort n)
    {
        if (n == 0)
            return "0";

        string hexchars = "0123456789ABCDEF";
        string result = "";

        while (n > 0)
        {
            int remainder = n % 16;
            result = hexchars[remainder] + result;
            n /= 16;
        }

        return result;
    }


   public static ushort Base16ToDecimal(string hexNumber)
   {
       if (hexNumber == null)
           throw new ArgumentNullException("wrong hexnumber");
   
       ushort result = 0;
       int power = 1;
   
       for (int i = hexNumber.Length - 1; i >= 0; i--)
       {
           char c = hexNumber[i];
           int digitValue;
   
           if (c >= '0' && c <= '9')
               digitValue = c - '0';
           else if (c >= 'A' && c <= 'F')
               digitValue = c - 'A' + 10;
           else if (c >= 'a' && c <= 'f')
               digitValue = c - 'a' + 10;
           else
               throw new FormatException("Invalid character in hexNumber");
           
           result += (ushort)(digitValue * power);
           power *= 16;
       }
   
       return result;
   }

    
   
   public static string HanoiTower(int n)
   {
       if (n < 1)
           throw new ArgumentException("N should be upper than 0.");

       return "";
   }
   
   

    public static void Main()
    {
        Console.WriteLine(Base16ToDecimal("6D44"));
    }
}