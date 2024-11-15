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

    [Fact(DisplayName = "All numbers not in a range is returned with comma separators")]
    public void AllNumbersNotInARange_IsReturnedWithCommaSeparators()
    {
        var result = Kata.Extract([1,3,5,7,9]);
        
        Assert.Equal("1,3,5,7,9", result);
    }
    
    [Fact(DisplayName = "Two numbers is not a range and is still returned with a comma separator")]
    public void TwoNumbersInARange_IsReturnedWithCommaSeparator()
    {
        var result = Kata.Extract([1,2]);
        
        Assert.Equal("1,2", result);
    }
    
    [Theory(DisplayName = "Three continuous numbers is a range and is returned in range notation")]
    [InlineData(new[] {1,2,3}, "1-3")]
    [InlineData(new[] {1,2,3,4,6,8,9,10}, "1-4,6,8-10")]
    public void ThreeNumbersInARange_IsReturnedWithDashSeparator(int [] input, string expected)
    {
        var result = Kata.Extract(input);
        
        Assert.Equal(expected, result);
    }
}