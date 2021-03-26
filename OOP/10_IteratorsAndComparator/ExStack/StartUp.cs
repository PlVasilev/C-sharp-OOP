using System;
using System.Collections.Generic;
using System.Linq;

namespace ExStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
           Stack<int> stack = new Stack<int>();

            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);


            while (true)
            {
                try
                {
                    switch (input[0])
                    {
                        case "Push":
                            List<int> paraInts = new List<int>();
                            for (int i = 1; i < input.Length; i++)
                            {
                                if (i == input.Length - 1)
                                {
                                    paraInts.Add(int.Parse(input[i].Trim()));
                                }
                                else
                                {
                                    int intTOAdd = int.Parse(input[i].Remove(input[i].Trim().Length - 1, 1));
                                    paraInts.Add(intTOAdd);
                                }
                            }
                            stack.Push(paraInts.ToArray());
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                        case "END":
                            foreach (var b in stack)
                            {
                                Console.WriteLine(b);
                            }
                            foreach (var b in stack)
                            {
                                Console.WriteLine(b);
                            }
                            return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
                input = Console.ReadLine().Split();
            }
           
        }
    }
}
