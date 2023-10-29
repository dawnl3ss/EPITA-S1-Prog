namespace Tests;

public class UnitTest1
{

   public static string EncodeCharacterFibo(char character)
    {
        string result = "1";
        int k = 2;

        if (character == '\0')
            throw new ArgumentOutOfRangeException("Can't encode the ASCII number 0.");
        
        int x = (int)character;

        if (x < 0)
            throw new ArgumentOutOfRangeException("Character value must be upper than 0.");
        if (x == 1)
            return "10";

        while (fibo(k) <= x)
        {
            k++;
        }

        for (int i = 1; i < k - 1; i++)
        {
            int fibKMinusI = fibo(k - i);
            if (fibKMinusI <= x)
            {
                result = "1" + result;
                x -= fibKMinusI;
            }
            else
                result = "0" + result;
            
        }

        return result;
    }

    public static int fibo(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0;
        int b = 1;
        int temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a;
            a = b;
            b = temp + b;
        }

        return b;
    }

    public static string EncodeFibo(string textToEncode)
    {
        string res = "";

        foreach (char chr in textToEncode)
        {
            res += EncodeCharacterFibo(chr);
        }

        return res;
    }

    
    [Theory]
    [InlineData("123", "010001011001001011101001011")]
    [InlineData("abc","000010000111000100001101001000011")]
    [InlineData("Schtroumpfer c'est douter !", "010100101101001000011010001000111001001001110100010011100000100110101001001101010100011010000100110000010001110101000011101000100110010101101001000011000100011101010000110001001001110010010011001010110010100001110000010011010100100111001001001110101000011101000100110010101110101011")]
    public static void Test(string str, string res)
    {
        
        Assert.Equal(res, EncodeFibo(str));
    }
}