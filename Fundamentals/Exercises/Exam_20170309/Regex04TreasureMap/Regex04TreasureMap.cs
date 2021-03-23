using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regex04TreasureMap
{
    class Regex04TreasureMap
    {
        static void Main(string[] args)
        {

            Regex instructionRegex = new Regex(@"![^!#]*?\b(?<street>[A-Za-z]{4})\b[^!#]*[^\d](?<number>\d{3})-(?<code>\d{6}|\d{4})(?:[^\d!#][^!#]*)?#|#[^!#]*?\b(?<street>[A-Za-z]{4})\b[^!#]*[^\d](?<number>\d{3})-(?<code>\d{6}|\d{4})(?:[^\d!#][^!#]*)?!");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = instructionRegex.Matches(input);
                Match match = matches[matches.Count / 2];
                Console.WriteLine("Go to str. {0} {1}. Secret pass: {2}.",
                    match.Groups["street"].Value, match.Groups["number"].Value, match.Groups["code"].Value);
            }

        }
    }
}
