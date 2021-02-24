using System;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewTasks
{
    public static class AsyncTask
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Main 1");
            var task = Do();
            Console.WriteLine("Main 2");
            await task;
            Console.WriteLine("Main 3");
        }

        public static async Task Do()
        {
            Console.WriteLine("Do 1");
            throw new ArgumentException();
        }
    }
    
    
    public static class AsyncTask2
    {
        static long _count = 0;

        static void Log()
        {
            var number = Interlocked.Increment(ref _count);
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"No - {number}, Thread - {threadId}");
        }

        static async void Do()
        {
            _count = 0;
            Log(); // No 1, Thread - 1
            await DoInternal();
            Log();
        }

        static async Task DoInternal()
        {
            Log();
            var t = Task.FromResult(0);
            Log();
            await t;
            Log();
        }
    }
}