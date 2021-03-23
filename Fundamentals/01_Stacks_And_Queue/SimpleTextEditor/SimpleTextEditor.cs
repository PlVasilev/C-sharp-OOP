using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());

            Stack<string> modifications = new Stack<string>();

            string text = "";

            for (int i = 0; i < operations; i++)
            {
                string[] operation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (operation[0])
                {
                    case "1":
                        text += operation[1];
                        modifications.Push(text);
                        break;
                    case "2":
                        int lenght = int.Parse(operation[1]);
                        string subText = text.Substring(0, text.Length - lenght);
                        text = subText;
                        modifications.Push(text);
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(operation[1])-1]);
                        break;
                    case "4":
                        modifications.Pop();
                        if (modifications.Count > 0)
                        {
                            text = modifications.Peek();
                        }
                        else
                        {
                            text = string.Empty;
                        }
                        break;
                    default:
                        break;
                }
            }

            //int count = int.Parse(Console.ReadLine());
            //Stack<string> texts = new Stack<string>();
            //texts.Push("");
            //
            //for (int i = 0; i < count; i++)
            //{
            //    var input = Console.ReadLine().Split();
            //
            //    switch (input[0])
            //    {
            //        case "1":
            //            string newText = texts.Peek() + input[1];
            //            texts.Push(newText);
            //            break;
            //        case "2":
            //            string previous = texts.Peek();
            //            int charsToCut = int.Parse(input[1]);
            //            string substring = previous.Substring(0, previous.Length - charsToCut);
            //            texts.Push(substring);
            //            break;
            //        case "3":
            //            string current = texts.Peek();
            //            int index = int.Parse(input[1]);
            //            Console.WriteLine(current[index - 1]);
            //            break;
            //        case "4":
            //            texts.Pop();
            //            break;
            //    }
            //}
        }
    }
}
