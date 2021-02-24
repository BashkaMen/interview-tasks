namespace InterviewTasks
{
    public static class ImplementMyWhere
    {
        public static ?? MyWhere(???)
        {
            throw new System.NotImplementedException();
        }

        public static void Run()
        {
            var source = new[] {1, 2, 3, 4, 5};

            var result = source
                .MyWhere(s => s % 2 == 0)
                .Take(2)
                .ToArray();
        }
    }
}