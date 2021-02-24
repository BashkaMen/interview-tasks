using System;
using System.Collections.Generic;

namespace InterviewTasks
{
    public static class DictionaryKey
    {
        public struct MyInt
        {
            private int _x;

            public MyInt(int x)
            {
                _x = x;
            }

            public void Increment()
            {
                _x++;
            }

            public override int GetHashCode()
            {
                return _x;
            }
        }

        public static void Run()
        {
            var dictionary = new Dictionary<MyInt, string>();
            var myInt = new MyInt(42);
            dictionary[myInt] = "some value";
            myInt.Increment();
            var res = dictionary[myInt]; // here we use res variable in some other method
            Console.WriteLine(res);
        }
    }
}