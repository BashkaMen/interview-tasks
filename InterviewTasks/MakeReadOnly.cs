using System;
using System.Collections.Generic;

namespace InterviewTasks
{
    public static class MakeReadOnly
    {
        public class A
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public B B { get; set; }
        }

        public class B
        {
            public List<string> Attributes { get; set; }
            public DateTime Created { get; set; }
        }
    }
}