using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_AlwaysPasses() => Assert.True(true);

        [Fact]
        public void Test_SimpleAddition() => Assert.Equal(4, 2 + 2);
    }
}