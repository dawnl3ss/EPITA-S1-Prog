class TheVillage
{
    
    public static (int, int) Euclidean(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();
        if (a >= 0 && a < Math.Abs(b))
            return (0, a);
        
        if ((a >= 0 && b >= 0) || (a < 0 && b < 0))
        {
            int quotient, remainder;
            (quotient, remainder) = Euclidean(a - b, b);
            return (quotient + 1, remainder);
        }
        else
        {
            int quotient, remainder;
            (quotient, remainder) = Euclidean(a + b, b);
            return (quotient - 1, remainder);
        }
    }
    
    
    

    private static bool ComputeCheckPrime(int n, int divisor)
    {
        if (divisor * divisor > n)
            return true;

        if (n % divisor == 0)
            return false;

        return ComputeCheckPrime(n, divisor + 1);
    }
    public static bool CheckPrime(int n)
    {
        if (n < 0)
            throw new ArgumentException("Parameter 'n' should be upper than 0");
        if (n <= 1)
            return false;
        
        return ComputeCheckPrime(n, 2);
    }
    
    
    
    
    
    public static int SumPrime(int n)
    {
        if (n <= 1)
            return 0;

        if (CheckPrime(n))
            return n + SumPrime(n - 1);
        
        return SumPrime(n - 1);
    }

    
    
    
    
    
    private static string ComputeReverseString(string text, int n)
    {
        if (n == 0)
            return "" + text[0];
        else
            return text[n] + ComputeReverseString(text, n - 1);
    }
    public static string ReverseString(string s)
    {
        return ComputeReverseString(s, s.Length - 1);
    }
    
    
    
    
    
    static void Main()
    {
        Console.WriteLine(ReverseString("123456789"));
    }
}