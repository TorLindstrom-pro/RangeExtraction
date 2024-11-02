namespace RangeExtraction;

public class Kata
{
    public static string Extract(int[] ints)
    {
        return ints
            .Select((i, idx) => i + (idx == ints.Length - 1 ? "" : ","))
            .Aggregate("", (acc, curr) => acc + curr);
    }
}