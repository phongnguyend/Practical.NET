using System;

namespace GenericTypes
{
    class Stack
    {
        int _fakeValue;

        public void Push(int number)
        {
            _fakeValue = number;
        }

        public int Pop()
        {
            return _fakeValue;
        }
    }

    class StackOfString
    {
        string _fakeValue;

        public void Push(string text)
        {
            _fakeValue = text;
        }

        public string Pop()
        {
            return _fakeValue;
        }
    }

    class StackOfDecimal
    {
        decimal _fakeValue;

        public void Push(decimal d)
        {
            _fakeValue = d;
        }

        public decimal Pop()
        {
            return _fakeValue;
        }
    }

    class StackOfObject
    {
        object _fakeValue;

        public void Push(object obj)
        {
            _fakeValue = obj;
        }

        public object Pop()
        {
            return _fakeValue;
        }
    }

    class Stack<T>
    {
        T _fakeValue;

        public void Push(T item)
        {
            _fakeValue = item;
        }

        public T Pop()
        {
            return _fakeValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            Demo2();
            Demo3();
        }

        private static void Demo1()
        {
            Stack stack1 = new Stack();
            stack1.Push(5);
            Console.WriteLine(stack1.Pop());

            StackOfDecimal stack2 = new StackOfDecimal();
            stack2.Push(5.5m);
            Console.WriteLine(stack2.Pop());

            StackOfString stack3 = new StackOfString();
            stack3.Push("Test");
            Console.WriteLine(stack3.Pop());
        }

        private static void Demo2()
        {
            StackOfObject stack1 = new StackOfObject();
            stack1.Push(5);
            Console.WriteLine(stack1.Pop());

            StackOfObject stack2 = new StackOfObject();
            stack2.Push(5.5m);
            Console.WriteLine(stack2.Pop());

            StackOfObject stack3 = new StackOfObject();
            stack3.Push("Test");
            Console.WriteLine(stack3.Pop());
        }

        private static void Demo3()
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(5);
            Console.WriteLine(stack1.Pop());

            Stack<decimal> stack2 = new Stack<decimal>();
            stack2.Push(5.5m);
            Console.WriteLine(stack2.Pop());

            Stack<string> stack3 = new Stack<string>();
            stack3.Push("Test");
            Console.WriteLine(stack3.Pop());
        }
    }
}
