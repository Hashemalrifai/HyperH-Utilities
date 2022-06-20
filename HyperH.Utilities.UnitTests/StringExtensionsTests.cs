namespace HyperH.Utilities.UnitTests;

public class StringExtensionsTests
{
    [Theory]
    [InlineData("", true)]
    [InlineData("  ", true)]
    [InlineData(null, true)]
    [InlineData("t", false)]
    [InlineData("text", false)]
    [InlineData("text   ", false)]
    public void IsNullOrWhiteSpaceWorks(string sourceString, bool expectedResult)
    {
        Assert.Equal(
            HyperH.Utilities.Extensions.StringExtensions.IsNullOrWhiteSpace(sourceString),
            expectedResult
            );
    }
}
