using Xunit;
using FluentAssertions;


namespace fluent_assertions_test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class TestSample
    {
        [Fact]
        public void validateString()
        {
            string userName = "Eduardo José";
            userName.Should().Be("Eduardo Guilarducci", "thats my real name :)");
           
        }

       
    }
}
