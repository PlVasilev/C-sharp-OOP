using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Prob1
{
    class Prob1
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> matchList = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string mainPattern = @"s:[^;]+?;r:[^;]+?;m--""[A-Za-z ]+""";
                Regex regex = new Regex(mainPattern);
                Match regexMatch = regex.Match(Console.ReadLine());

                if (regexMatch.Success)
                {
                   matchList.Add(regexMatch.Value);
                }
            }

            int sum = 0;
            for (int i = 0; i < matchList.Count; i++)
            {
                string[] matchArr = matchList[i].Split(";", StringSplitOptions.RemoveEmptyEntries);
                string sender = matchArr[0].Substring(2, matchArr[0].Length - 2);
                string reciever = matchArr[1].Substring(2, matchArr[1].Length - 2);
                string message =  matchArr[2].Substring(4, matchArr[2].Length - 5);
                string senderToPrint = "";
                string recieverToPrint = "";
                for (int j = 0; j < sender.Length; j++)
                {
                    if (sender[j] > 47 && sender[j] < 58)
                    {
                        sum += sender[j] - 48;
                    }
                    else if (sender[j] == 32 || (sender[j] > 64 && sender[j] < 91) || (sender[j] > 96 && sender[j] < 123))
                    {
                        senderToPrint += sender[j];
                    }
                }

                for (int j = 0; j < reciever.Length; j++)
                {
                    if (reciever[j] > 47 && reciever[j] < 58)
                    {
                        sum += reciever[j] - 48;
                    }
                    else if (reciever[j] == 32 || (reciever[j] > 64 && reciever[j] < 91) || (reciever[j] > 96 && reciever[j] < 123))
                    {
                        recieverToPrint += reciever[j];
                    }
                }
                Console.WriteLine($"{senderToPrint} says \"{message}\" to {recieverToPrint}");
            }
            Console.WriteLine($"Total data transferred: {sum}MB");
        }
    }
}
