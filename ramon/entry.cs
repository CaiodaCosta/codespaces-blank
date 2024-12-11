using System;

public class Program
{
    static void Main(string[] args)
    {
        string[] inputArr   = ["SEI", "QUE", "VOCÊ", "VAI", "QUERER", "SER", "UMA", "DE", "NÓS!"];
        int[] numbers       = [1, 2, 3, 4, 1000];

        string[] test       = Filter(inputArr, target => target == "VAI");
        int resultInt       = Find(numbers, target => target == 2);
        int[] newNumbersArr = Map(numbers, target => target * 2);
    }

    private static T? Find<T>(T[] inputArr, Func<T, bool> inputCondition)
    {
        foreach (T currentObj in inputArr)
        {
            if (inputCondition(currentObj))
                return currentObj;
        }

        return default;
    }

    private static T[] Filter<T>(T[] inputArr, Func<T, bool> inputCondition)
    {
        var resultArr = Array.Empty<T>();

        foreach (T currentObj in inputArr)
        {
            if (inputCondition(currentObj))
                resultArr = resultArr.Append(currentObj).ToArray();
        }

        return resultArr;
    }

    private static T[] Map<T>(T[] inputArr, Func<T, T> inputCondition)
    {
        var resultArr = Array.Empty<T>();

        foreach (T currentObj in inputArr)
        {
            resultArr = resultArr.Append(inputCondition.Invoke(currentObj)).ToArray();
        }

        return resultArr;
    }
}
