using System.Collections.Immutable;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] testArray = new int[1000000];
        List<int> testList = new List<int>();
        for (int i = 0; i < 1000000; i++)
        {
            //testArray[i] = i;
            testList.Add(i);  
        }
        DateTimeOffset timeBeforeArrayIteration = (DateTimeOffset)DateTime.UtcNow;
        foreach (int i in testList)
        {
            Console.WriteLine(i);
        }
        DateTimeOffset timeAfterArrayIteration = (DateTimeOffset)DateTime.UtcNow;
        Console.WriteLine(timeBeforeArrayIteration.ToString());
        Console.WriteLine(timeAfterArrayIteration.ToString());
        // 28 seconds for array
    }

}
