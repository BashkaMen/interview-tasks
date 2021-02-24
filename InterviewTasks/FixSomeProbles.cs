using System;
using System.Threading.Tasks;

namespace InterviewTasks
{
    public static class FixSomeProblems
    {
        public interface IKafka
        {
            T Consume<T>();
        }

        public class Data
        {
            public string Payload { get; set; }
        }


        private static readonly IKafka _kafka;

        public static async Task ConsumerProcess()
        {
            while (true)
            {
                var msg = _kafka.Consume<Data>();

                Console.WriteLine(msg.Payload);
            }
        }

        public static async Task RunApp()
        {
            var consumerTask = ConsumerProcess();

            Console.WriteLine("Do another work");

            await consumerTask;
        }
    }
}