using Xunit;

namespace Colotiline.GoLikeTests.Directory.Subdirectory;

public sealed class GreetingTests
{
    [Fact]
    public void Create_Valid_Ok()
    {
        var createdGreeting = Greeting.Create("Polly");

        Assert.Equal("Oh, hi Polly.", createdGreeting);
    }
}