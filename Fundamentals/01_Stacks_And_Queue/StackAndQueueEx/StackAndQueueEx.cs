using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueueEx
{
    class StackAndQueueEx
    {
        static void Main(string[] args)
        {
            Stack<long> fibunachi = new Stack<long>();
            fibunachi.Push(0);
            fibunachi.Push(1);
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num - 1; i++)
            {
                long b = fibunachi.Pop();
                long a = fibunachi.Pop();
                long c = a + b;
                fibunachi.Push(b);
                fibunachi.Push(c);
            }
            Console.WriteLine(fibunachi.Pop());
           
        }
    }
}
