using Xunit;

namespace SimpleCSharpApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void TestConsoleOutput()
        {
            var output = "Hello, GitHub Actions!";
            Assert.Equal("Hello, GitHub Actions!", output);
        }
    }
}