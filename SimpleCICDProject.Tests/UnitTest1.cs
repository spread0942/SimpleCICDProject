namespace SimpleCICDProject.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void HelloWorldTest()
    {
        var message = "Hello, World!";
        Assert.Equal("Hello, World!", message);
    }
}