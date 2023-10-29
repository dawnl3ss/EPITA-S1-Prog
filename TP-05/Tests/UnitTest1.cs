namespace Tests;

public class UnitTest1
{
 
    public static string Pyramid(ulong height, char block)
    {
        string res = "";

        for (ulong i = 0; i < height; i++)
        {
            for (ulong j = 0; j < height - i - 1; j++)
            {
                res += ' ';
            }

            for (ulong k = 0; k < 2 * i + 1; k++)
            {
                res += block;
            }

            for (ulong j = 0; j < height - i - 1; j++)
            {
                res += ' ';
            }
            
            res += '\n';
        }

        return res;
    }
    
    [Theory]
    [InlineData(1, '*', "*\n")]
    [InlineData(2, '+', " + \n+++\n")]
    [InlineData(3, '*', "  *  \n *** \n*****\n")]
    public static void Test(ulong height, char block, string res)
    {
        Assert.Equal(res, Pyramid(height, block));
    }
}