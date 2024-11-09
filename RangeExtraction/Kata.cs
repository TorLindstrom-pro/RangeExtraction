namespace RangeExtraction;

public class Kata
{
    public static string Extract(int[] ints)
    {
        var result = "";
        
        var rangeStartIndex = 0;
        for (var i = 0; i < ints.Length; i++)
        {
            var rangeStarts = i == 0 || ints[i - 1] != ints[i] - 1;
            var rangeContinues = i != ints.Length - 1 && ints[i + 1] == ints[i] + 1;
            var end = i == ints.Length - 1;
            
            if (rangeStarts)
            {
                result += ints[i] + (end || rangeContinues ? "" : ",");
                rangeStartIndex = i;
            }
            else if (!rangeContinues)
            {
                result += (i - rangeStartIndex > 1 ? "-" : ",") + ints[i] + (end ? "" : ",");
            }
        }

        return result;
    }
}