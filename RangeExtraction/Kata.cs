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
            
            if (rangeStarts && rangeContinues)
            {
                rangeStartIndex = i;
                result += ints[i];
            }
            else if (rangeStarts)
                result += ints[i] + (i == ints.Length - 1 ? "" : ",");
            else if (!rangeContinues)
            {
                result += (i - rangeStartIndex > 1 ? "-" : ",") + ints[i];
                rangeStartIndex = i;
            }
        }

        return result;
    }
}