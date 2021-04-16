using System;
using Xunit;

namespace Tests
{
    public class ExampleTests
    {
        [Fact]
        public void ValidTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void InvalidTest()
        {
            Assert.True(false);
        }
    }
}
