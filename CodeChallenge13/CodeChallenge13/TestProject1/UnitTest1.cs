using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestValidBrackets()
        {
            // Arrange
            string input1 = "{}";
            string input2 = "{}(){}";
            string input3 = "()[[Extra Characters]]";
            string input4 = "(){}[[]]";
            string input5 = "{}{Code}[Fellows](())";

            // Act & Assert
            Assert.True(Program.validateBrackets(input1));
            Assert.True(Program.validateBrackets(input2));
            Assert.True(Program.validateBrackets(input3));
            Assert.True(Program.validateBrackets(input4));
            Assert.True(Program.validateBrackets(input5));
        }

        [Fact]
        public void TestInvalidBrackets()
        {
            // Arrange
            string input1 = "[({}]";
            string input2 = "(](";
            string input3 = "{(})";

            // Act & Assert
            Assert.False(Program.validateBrackets(input1));
            Assert.False(Program.validateBrackets(input2));
            Assert.False(Program.validateBrackets(input3));
        }
    }
}
