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
    public void IsNullOrWhiteSpace_Works(string sourceString, bool expectedResult)
    {
        Assert.Equal(
            HyperH.Utilities.Extensions.StringExtensions.IsNullOrWhiteSpace(sourceString),
            expectedResult
            );
    }

    [Theory]
    [InlineData("", false)]
    [InlineData("  ", false)]
    [InlineData(null, false)]
    [InlineData("t", true)]
    [InlineData("text", true)]
    [InlineData("text   ", true)]
    [InlineData(" t  ext   ", true)]
    public void HasValue_Works(string sourceString, bool expectedResult)
    {
        Assert.Equal(
            HyperH.Utilities.Extensions.StringExtensions.HasValue(sourceString),
            expectedResult
            );
    }
}
