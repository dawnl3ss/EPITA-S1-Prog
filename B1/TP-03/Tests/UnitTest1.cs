namespace Tests;

public class UnitTest1
{
    
    
    [Theory]
    [InlineData("1 1 1", 1)]
    [InlineData("0 1 2 2 4 5 5 7 7", 7)]
    [InlineData("9 9 9 7 5 3 2 1 0", 9)]
    [InlineData("1 3 4 6 8 9 7 5 3 0", 9)]
    [InlineData("1 3 4 6 7 5 3 8", -1)]
    [InlineData("1 2 3 2 1 2 5 5 1", -1)]
    [InlineData("", -1)]
    public void SomeTest(string n, int res)
    {
        //Assert.Equal(res, KingOfTheHill(n));
    }
}