using BabySmurf.DebugMe;

namespace Tests;

public class UnitTest
{
    [Theory]
    [InlineData(0f, 1f, 2f, 3f, 3f)]
    [InlineData(-0.1f, 0f, -3f, -2f, 0f)]
    [InlineData(2f, 3f, 3.4f, 2f, 3.4f)]
    [InlineData(8f, 0f, -1f, 5f, 8f)]
    public static void Max_Tests(double a, double b, double c, double d, double res)
    {
        Assert.Equal(res, First.Max(a, b, c, d));
    }
}