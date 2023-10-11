namespace SmurfLooping;

public class Travel
{
    
    public static string SmurfGame(int n)
    {
        string str = "";

        if (n < 1)
            throw new ArgumentException("Parameter 'n' must be >= 1");
        
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                str += "Papa Smurf";
                if (i != n)
                    str += " ";
                continue;
            }
            
            if (i % 3 == 0)
                str += "Papa";
            
            else if (i % 5 == 0)
                str += "Smurf";
            else
                str += i.ToString();
            
            if (i != n)
                str += " ";
        }

        return str;
    }


    public static bool IsPalindrome(string s)
    {
        string newStr = "";
        string revStr = "";
        
        foreach (char chr in s)
        {
            if (chr != ' ' && chr != ',' && chr != '!' && chr != '?' && chr != ':' && chr != '.')
            {
                newStr += chr;
            }
        }
        
        foreach (char chr in newStr)
        {
            revStr = chr + revStr;
        }

        return newStr == revStr;
    }


    public static int ReverseNumber(int n)
    {
        int result = 0;
        int nn = Int32.Abs(n);
        
        while (nn > 0) 
        {
            result = (result * 10) + (Int32.Abs(nn) % 10);
            nn /= 10;
        }
        if (n < 0)
            return -result;
        return result;
    }

    public static int GCD(int a, int b)
    {
        b = Int32.Abs(b);
        
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }


    public static bool CheckPrime(int n)
    {
        if (n <= 1)
            return false;

        if (n <= 3)
            return true;
        
        if (n % 2 == 0 || n % 3 == 0)
            return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }
}