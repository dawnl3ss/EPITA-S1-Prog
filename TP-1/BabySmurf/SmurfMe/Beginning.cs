namespace BabySmurf.SmurfMe;

public class Beginning
{
    public static string HelloWorld()
    {
        Console.WriteLine("Hello World!\n");
        return "Hello World!\n";
    }
        
    public static string HelloYou(string name)
    {
        Console.WriteLine("Hello " + name + ", have a good day in the village!\n");
        return "Hello " + name + ", have a good day in the village!\n";
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Absolute(int a)
    {
        return Int32.Abs(a);
    }

    public static bool Xor(bool b1, bool b2)
    {
        return !b1 == b2;
    }
    public static string SmurfSnurf(int n)
    {
        if (n % 15 == 0)
            return "SmurfSnurf";
        else if (n % 5 == 0) 
            return "Snurf";
        else if (n % 3 == 0)
            return "Smurf";
        else
            return n.ToString();
    }
}
