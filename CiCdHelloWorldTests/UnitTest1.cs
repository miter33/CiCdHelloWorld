using CiCdHelloWorld;
using System;
using Xunit;

namespace CiCdHelloWorldTests
{
    public class ProgramTests
    {
        [Fact]
        public void GetFlagTest()
        {
            var program = new Program();
            Assert.True(program.GetFlag());
        }
    }
}
