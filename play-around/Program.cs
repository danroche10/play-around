using System;
using System.Threading;
using System.Threading.Tasks;

class Example
{
    static void Main()
    {
        Test test = new Test();
        test.GetDataAsync();
    }
    class Test
    {
        public async Task<string> GetDataAsync()
        {
            // Use the await keyword to wait for the task to complete.
            string data = await SomeAsyncMethod();

            // Now that the task is complete, you can use the data that was returned.
            return data;
        }

        public async Task<string> SomeAsyncMethod()
        {
            Thread.Sleep(20000);
            return "test";
        }
    }




}