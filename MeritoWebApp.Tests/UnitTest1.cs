using Xunit;

namespace MeritoWebApp.Tests;

public class WebAppTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(true, "This test is always true.");
    }
}

public class HomeControllerTests
{
    [Fact]
    public void TestHelloWorld()
    {
       Assert.Equal("Hello world!", "Hello world!");
    }
}