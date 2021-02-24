using System.Threading.Tasks;

namespace InterviewTasks
{
    public class ImplementAsyncChannel
    {
        public interface IAsyncChannel<T>
        {
            void Consume(T msg);
            Task<T> Produce();
        }

        public class AsyncChannel<T> : IAsyncChannel<T>
        {
            public void Consume(T msg)
            {
                throw new System.NotImplementedException();
            }

            public Task<T> Produce()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}