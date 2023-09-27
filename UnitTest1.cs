using Xunit;
namespace Tests;

public class UnitTest1
{

    [Theory]
    [InlineData(10, 8, 2)]
    [InlineData(-13, 11, 9)]
    [InlineData(-24, 4, 0)]
    [InlineData(-40, 13, 12)]
    [InlineData(62, 0, -1)]
    
    public static void Max_Tests(int a, int b, int res)
    {
        Assert.Equal(res, BabySmurf.SmurfMe.Division.Remainder(a, b));
    }

}