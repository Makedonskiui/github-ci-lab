[Fact]
public void Test_BadExample_ShouldFail()
{
    int result = 2 + 2;
    Assert.Equal(5, result);  // ❌ Намеренно неправильно
}