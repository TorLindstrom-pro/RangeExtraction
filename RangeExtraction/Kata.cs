namespace RangeExtraction;

public class Kata
{
    private static int[]? _ints;
    
    public static string Extract(int[] ints)
    {
        _ints = ints;
        
        return _ints
            .Select((i, idx) => i + (IsLastNumber(idx) ? "" : ChooseSeparator(i, idx)))
            .Aggregate("", (acc, curr) => acc + curr);
    }

    private static string ChooseSeparator(int i, int idx)
    {
        return _ints![idx + 1] == i + 1 ? "-" : ",";
    }

    private static bool IsLastNumber(int idx)
    {
        return idx == _ints!.Length - 1;
    }
}