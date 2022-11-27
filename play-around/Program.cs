delegate bool MeDelegate(int n);

class MainClass
{
    static void Main()
    {
        int[] numbers = { 2, 7, 3, 9, 5, 7, 1, 8, 64, 1000 };
        IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, n => n < 5);
        foreach(int n in result)
            Console.WriteLine(n);
    }
    static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDelegate gauntlet)
    {
        foreach(int number in numbers)
            if (gauntlet(number))
                yield return number;
    }
}