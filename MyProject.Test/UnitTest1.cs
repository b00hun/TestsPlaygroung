using System.Text;
using Xunit;

namespace MyProject.Test
{
    public class StringBuilderTests
    {
        [Fact]
        public void Append_ForTwoStrings_ReturnsConcatenatedTwoStrings()
        {
            //arrange

            StringBuilder sb = new();

           
            // act

            sb.Append("test")
                .Append("test2");

            string result = sb.ToString();

           
            // assert

            Assert.Equal("testtest2", result);
        }
    }
}