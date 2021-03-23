using System;
using System.Collections.Generic;

namespace ReverceString
{
    class ReverceString
    {
        static void Main(string[] args)
        {
            Stack<char> reverceString = new Stack<char>();

            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                reverceString.Push(ch);
            }

            foreach (var item in reverceString)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
