namespace RangeExtraction;

public class Kata
{
    private static int[]? _ints;

    public static string Extract(int[] ints)
    {
        _ints = ints;
        
        return _ints
            .Select(SeparatorForEachNumber())
            .Aggregate("", IntoAString());
    }

    private static Func<int, int, string> SeparatorForEachNumber()
    {
        return (number, index) => number + (IsLastNumber(index) ? "" : ChooseSeparator(number, index));
    }

    private static string ChooseSeparator(int i, int idx)
    {
        return _ints![idx + 1] == i + 1 ? "-" : ",";
    }

    private static bool IsLastNumber(int idx)
    {
        return idx == _ints!.Length - 1;
    }

    private static Func<string, string, string> IntoAString()
    {
        return (accumulate, current) => accumulate + current;
    }
}