namespace InterviewTasks
{
    public static class ImplementChannel
    {
        public interface IChannel
        {
            void Produce<T>(T msg); // non blocking
            T Consume<T>(); // blocked until it receives a message
        }

        public class Channel : IChannel
        {
            public void Produce<T>(T msg)
            {
                throw new System.NotImplementedException();
            }
            
            public T Consume<T>()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}