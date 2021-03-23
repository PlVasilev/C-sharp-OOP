using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regex01Regeh
{
    class Regex01Regeh
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string paternt = @"\[[^\[\s]+<(\d+)REGEH(\d+)>[^\s]*?\]";//  \[[^\[^\s]+?<(\d+)REGEH(\d+)>[^\s]+?] 
                                                                     //  \[[^\[^\s+]+?<([0-9]+)REGEH([0-9]+)>[^\[^\s+]+?\]
            Regex regex = new Regex(paternt);
            MatchCollection matches = regex.Matches(input);
            List<int> indexes = new List<int>();
            foreach (Match match in matches)
            {
                indexes.Add(int.Parse(match.Groups[1].ToString()));
                indexes.Add(int.Parse(match.Groups[2].ToString()));
            }

            string result = "";
            int currentIndex = 0;
            for (int i = 0; i < indexes.Count; i++)
            {
                currentIndex += indexes[i];
                if (currentIndex >= input.Length)
                {
                    int indexToAdd = (currentIndex % input.Length) + 1;
                    result += input[indexToAdd];

                }
                else
                {
                    result += input[currentIndex];
                }
               
            }
            if (result.Length > 0)
            {
                Console.WriteLine(result);
            }

        }
    }
}
