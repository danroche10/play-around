class MainClass
{
    static void Main()
    {
        Cow cow = new Cow();
        cow.mooing += 
            () => Console.WriteLine("Handler");
        cow.PushSleepingCow();
    }
}