using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<string> words = ["SEI", "QUE", "VOCÊ", "VAI", "QUERER", "SER", "UMA", "DE", "NÓS!"];
        List<int> numbers = [1, 2, 3, 4, 1000];

        int resultInt = Find(numbers, target => target == 2);
        List<string> filteredWords = Filter(words, target => target == "VAI").ToList();
        List<int> processedNumbers = Map(numbers, target => target * 2).ToList();
    }

    private static T? Find<T>(List<T> inputList, Func<T, bool> inputCondition)
    {
        foreach (T currentObj in inputList)
        {
            if (inputCondition(currentObj))
                return currentObj;
        }

        return default;
    }

    private static IEnumerable<T> Filter<T>(List<T> inputList, Func<T, bool> inputCondition)
    {
        foreach (T currentObj in inputList)
        {
            if (inputCondition(currentObj))
                yield return currentObj;
        }
    }

    private static IEnumerable<T> Map<T>(List<T> inputList, Func<T, T> inputCondition)
    {
        foreach (T currentObj in inputList)
        {
            yield return inputCondition.Invoke(currentObj);
        }
    }

    private static T Reduce<T>(List<T> inputList, Func<T, T, T> inputCondition, T initialValue)
    {
        dynamic result = initialValue;

        for (int count = 0; count < inputList.Count; count++)
            result = inputCondition.Invoke(result, inputList[count]);

        return result;
    }
}
