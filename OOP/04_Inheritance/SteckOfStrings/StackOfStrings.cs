using System;

namespace SteckOfStrings
{
    class StackOfStrings
    {
        static void Main(string[] args)
        {
            var stack = new StringStack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
