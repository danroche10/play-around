using System.Collections.Immutable;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        void IncreaseValue(ref int x)
        {
            double useUpStack = Math.Pow(100, 10000000000000);
            x++;
            
            StackTrace stackTrace = new StackTrace();
            int stackFrames = stackTrace.FrameCount;
            if (x % 1000 == 0)
            {
                Console.WriteLine(x);
                Console.WriteLine("Stack frames: {0} used", stackFrames);
            }
            IncreaseValue(ref x);
        }

        int myInt = 5;
        IncreaseValue(ref myInt);
    }
}
