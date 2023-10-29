namespace SmurfasticFibo.Fundamentals;

public static class FibonacciCoding
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
    
    public static char DecodeCharacterFibo(string encodedCharacter)
    {
        
        if (!encodedCharacter.EndsWith("11"))
            throw new ArgumentException("The encoded character does not feature the end mark '11' at the end.");
        
        string encoded = encodedCharacter.Substring(0, encodedCharacter.Length - 2); // Remove the last '11'
        int result = 0;
        int i = encoded.Length - 1;
        int fibKMinusI = 1;
        
        while (i >= 0)
        {
            if (encoded[i] == '1')
                result += fibKMinusI;
            
            i--;
            int temp = fibKMinusI;
            fibKMinusI = fibKMinusI + result;
            result = temp;
        }

        return (char)result;
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

    
    public static string DecodeFibo(string encodedText)
    {
        if (encodedText.Length < 2)
            throw new ArgumentException("Encoded text is too short.");
        

        string decodedText = "";
        int startIndex = 0;

        while (startIndex < encodedText.Length)
        {
            string encodedCharacter = "";

            if (encodedCharacter.Length < 2 || !encodedCharacter.EndsWith("11"))
                throw new ArgumentException("Invalid encoded character.");
            

            char decodedCharacter = DecodeCharacterFibo(encodedCharacter);
            decodedText.Append(decodedCharacter);
        }

        return decodedText;
    }
}