using System.Threading;
using Xunit;
using FluentAssertions;

namespace UnitTests
{
    [Collection("Our Test Collection #1")]
    public class UnitTest2
	{
        [Fact]
        public void Test2()
        {
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }
    }
}

