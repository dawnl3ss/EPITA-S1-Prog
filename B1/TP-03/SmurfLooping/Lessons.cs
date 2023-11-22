namespace SmurfLooping;

public class Lessons
{
    public static string PrintNumbers(int n)
    {
        if (n < 1)
            throw new ArgumentException("Parameter 'n' should be upper than 0");
        
        string str = "";
        
        for (sbyte i = 1; i < n; i++)
        {
            str += i + " ";
        }

        return str + n;
    }


    public static int Fibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be a positive integer");
        if (n == 0)
            return 0;
        if (n == 1 || n == 2)
            return 1;
        
        
        int fib1 = 1;
        int fib2 = 1;
        int fibonacci = 0;

        for (int i = 3; i <= n; i++)
        {
            fibonacci = fib1 + fib2;
            fib1 = fib2;
            fib2 = fibonacci;
        }

        return fibonacci;
    }


    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Parameter 'n' must be upper or equal to 0");
        
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    public static float MyPow(int a, int b)
    {
        float result = 1;
        
        if (b == 0)
            return result;

        if (b > 0)
        {
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
        }
        else if (b < 0)
        {
            
            for (int i = -1; i >= b; i--)
            {
                result *= a;
            }
            result = 1 / result;
        }

        return result;
    }


    public static string ReverseString(string s)
    {
        string result = "";

        foreach (char chr in s)
        {
            result = chr + result;
        }

        return result;
    }


    public static bool SearchLetter(string s, char c)
    {
        int i = 0;
        bool find = false;
        bool cond = false;

        while (!cond)
        {
            if (i <= s.Length - 1)
            {
                if (s[i] == c)
                {
                    find = true;
                    cond = true;
                }
            }
            else
                cond = true;
            
            i++;
        }

        return find;
    }
}