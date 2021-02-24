namespace InterviewTasks
{
    public static class SharedState
    {
        public class State
        {
            public int Balance { get; set; }
        }

        public class BalanceService
        {
            private readonly State _state;

            public BalanceService(State state)
            {
                _state = state;
            }

            public void Change(int amount)
            {
                _state.Balance += amount;
            }
        }

        public class App
        {
            private readonly BalanceService _service;

            public App(BalanceService service)
            {
                _service = service;
            }

            public void Run()
            {
                _service.Change(10);
            }
        }
    }
}