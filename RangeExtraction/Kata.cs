namespace RangeExtraction;

public class Kata
{
    public static string Extract(int[] ints)
    {
        const string separator = ",";
        const string rangeSeparator = "-";
        
        var result = "";
        var rangeStartIndex = 0;

        for (var index = 0; index < ints.Length; index++)
        {
            var currentNumber = ints[index];
            var isLastNumber = index == ints.Length - 1;

            var rangeStarts = index == 0 || !ContinuousWithPrevious(index, currentNumber);
            var rangeContinues = !isLastNumber && ContinuousWithNext(index, currentNumber);

            if (rangeStarts)
            {
                result += AppendRangeStart(currentNumber, isLastNumber, rangeContinues);
                rangeStartIndex = index;
            }
            else if (!rangeContinues)
            {
                var rangeLength = index - rangeStartIndex;
                result += AppendRangeEnd(rangeLength, currentNumber, isLastNumber);
            }
        }

        return result;

        bool ContinuousWithPrevious(int index, int currentNumber) => ints[index - 1] == currentNumber - 1;

        bool ContinuousWithNext(int index, int currentNumber) => ints[index + 1] == currentNumber + 1;

        string AppendRangeStart(int currentNumber, bool isLastNumber, bool rangeContinues) => 
            currentNumber + (isLastNumber || rangeContinues ? "" : separator);

        string AppendRangeEnd(int rangeLength, int currentNumber, bool isLastNumber) => 
            (rangeLength > 1 ? rangeSeparator : separator) + currentNumber + (isLastNumber ? "" : separator);
    }
}