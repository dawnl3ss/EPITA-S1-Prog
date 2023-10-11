namespace SmurfRecursion;

public class Basics
{

    public static string HelloSmurfs(int n)
    {
        if (n <= 0)
            throw new ArgumentException("Parameter 'n' must be > 0");
        else if (n == 1)
            return "Hello Smurfs!";
        else
            return "Hello Smurfs!\n" + HelloSmurfs(n - 1);
    }

    public static int Fibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("Parameter 'n' must be >= 0");
        else if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Parameter 'n' must be >= 0");
        else if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    public static int MyPow(int a, int b)
    {
        
        if (b < 0)
            throw new ArgumentException("Parameter 'n' must be >= 0");
        if (b == 0)
            return 1;
        else if (b == 1)
            return a;
        else
            return a * MyPow(a, b - 1);
    }

    public static int SumDigits(int n)
    {
        if (n < 0)
            n = -n;
        if (n < 10)
            return n;
        else
            return n%10 + SumDigits(n/10);
    }

    public static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return GCD(b, a%b);
    }
    
    public static int DebugMe(int a)
    {
        if (a < 0)
            throw new ArgumentException("a needs to be positive");
        if (a == 0)
            return 0;
        if (a % 5 == 0)
            return 5 + DebugMe(a - 1);
        else
            return 1 + DebugMe(a - 1);
    }
}