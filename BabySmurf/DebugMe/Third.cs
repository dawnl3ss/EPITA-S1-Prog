namespace BabySmurf.DebugMe;

public class Third
{
    public static int BinToInt(string bin)
    {
        int sum = -1;
        if (bin.Length == 8)
        {
            sum = 0;
            sum += (bin[7] - '0') * 1;
            sum += (bin[6] - '0') * 2;
            sum += (bin[5] - '0') * 4;
            sum += (bin[4] - '0') * 8;
            sum += (bin[3] - '0') * 16;
            sum += (bin[2] - '0') * 32;
            sum += (bin[1] - '0') * 64;
            sum += (bin[0] - '0') * 128;
        }
        return sum;
    }
}