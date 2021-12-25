using System;
using Xunit;

namespace CiCdHelloWorld.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void MainTest()
        {
            var program = new Program();

            var result = program.GetFlag();
            Assert.True(result);
        }
    }
}
