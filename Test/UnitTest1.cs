using RangeExtraction;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "One number is returned as is")]
    public void OneNumber_IsReturnedAsIs()
    {
        var result = Kata.Extract([1]);
        
        Assert.Equal("1", result);
    }
}