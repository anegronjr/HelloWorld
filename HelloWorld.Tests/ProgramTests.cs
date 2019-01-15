using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Hello_World_Test()
        {
            Assert.Equal("Hello", "Hello");
        }
    }
}
