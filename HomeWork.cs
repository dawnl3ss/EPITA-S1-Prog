namespace SmurfasticFibo.Fundamentals;

public static class HomeWork
{
    public static long FibonacciRecursive(ushort nb)
    {
        if (nb == 0)
            return 0;
        else if (nb == 1)
            return 1;
        else
            return FibonacciRecursive(Convert.ToUInt16(nb - 1)) + FibonacciRecursive(Convert.ToUInt16(nb - 2));
    }

    public static long FibonacciIterative(ushort nb)
    {
        if (nb == 0)
            return 0;
        if (nb == 1 || nb == 2)
            return 1;
        
        int fib1 = 1;
        int fib2 = 1;
        int fibonacci = 0;

        for (int i = 3; i <= nb; i++)
        {
            fibonacci = fib1 + fib2;
            fib1 = fib2;
            fib2 = fibonacci;
        }

        return fibonacci;
    }
}