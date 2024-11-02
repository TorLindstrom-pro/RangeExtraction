namespace RangeExtraction;

public class Kata
{
    public static string Extract(int[] ints)
    {
        return ints.Length == 1 ? ints[0].ToString() : ints[0] + "," + ints[1];
    }
}