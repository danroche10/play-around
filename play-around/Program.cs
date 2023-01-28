using System.Collections.Immutable;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Program program = new Program();
        int refNumber = 10;
        int valueNumber = 10;
        program.refTest(ref refNumber);
        program.valueTest(valueNumber);
        Console.WriteLine("refNumber = {0}", refNumber);
        Console.WriteLine("valueNumber = {0}", valueNumber);
    }

   private void refTest(ref int number)
    {
        number++;
    }
    private void valueTest(int number)
    {
        number++;
    }
}
