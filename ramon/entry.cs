using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<string> words           = ["SEI", "QUE", "VOCÊ", "VAI", "QUERER", "SER", "UMA", "DE", "NÓS!"];
        List<int> numbers            = [1, 2, 3, 4];
        List<int> scrambledNumbers   = [10, 2, 36, 47, 1, 74, 157, 171];

        int resultInt                = Find(numbers, target => target == 2);
        List<string> filteredWords   = Filter(words, target => target == "VAI").ToList();
        List<int> processedNumbers   = Map(numbers, target => target * 2).ToList();

        resultInt                    = Reduce(numbers, (left, right) => left * right, 15);
        words                        = Sort(words).ToList();
        scrambledNumbers             = Sort(scrambledNumbers).ToList();
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

    private static IEnumerable<T> Sort<T>(List<T> inputList)
    {
        List<T> resultList = inputList;

        if (resultList.Count <= 1)
            return resultList;

        int isOrdered = 0;

        do
        {
            isOrdered = 0;

            for (int count = 0; count < resultList.Count; count++)
            {
                if (count >= resultList.Count - 1)
                    break;

                string firstValue   = resultList[count].ToString();
                string secondValue  = resultList[count + 1].ToString();

                for (int innerCount = 0; innerCount < firstValue.Length; innerCount++)
                {
                    if (innerCount >= secondValue.Length)
                    {
                        isOrdered = ChangePositions(resultList, isOrdered, count);
                        break;
                    }

                    if (firstValue[innerCount] == secondValue[innerCount])
                        continue;

                    if (firstValue[innerCount] > secondValue[innerCount])
                    {
                        isOrdered = ChangePositions(resultList, isOrdered, count);
                    }

                    break;
                }
            } 
        } while (isOrdered != 0);

        return resultList;
    }

    private static int ChangePositions<T>(List<T> result, int isOrdered, int count)
    {
        T aux = result[count + 1];
        result[count + 1] = result[count];
        result[count] = aux;

        return ++isOrdered;
    }
}

