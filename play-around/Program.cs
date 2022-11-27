public class MainClass
{
    static int count = 0;
    static object baton = new object();
    static Dictionary<int, int> map = new Dictionary<int, int> {
        {0, 0}
    };
    static void Main()
    {
        var thread1 = new Thread(IncremenetCount);
        var thread2 = new Thread(IncremenetCount);
        thread1.Start();
        Thread.Sleep(500);
        thread2.Start();
    }

    static void IncremenetCount()
    {
        while(true)
        {
            lock (baton)
            {
                int temp = map[0];
                Thread.Sleep(1000);
                map[0] = temp + 1;
                count++;
                Console.WriteLine("Thread ID" + Thread.CurrentThread.ManagedThreadId +
                    " incremented count to " + map[0]);
                Thread.Sleep(1000);
            }
        }
    }
    
}