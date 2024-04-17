namespace projectzero.Tests;
using projectzero;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {var result = Menu.UserChoice(1, 2);
    Assert.Equal(typeof(int), result.GetType());
    }
}