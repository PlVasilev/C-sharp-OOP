using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexEx3CryptoBlockchain
{
    class RegexEx3CryptoBlockchain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string sequence = "";

            string output = "";

            for (int i = 0; i < n; i++)
            {
                sequence += Console.ReadLine();
            }

            string pattern = @"{[^\]\[{]+}|\[[^{}\[]+\]";
            MatchCollection matches = Regex.Matches(sequence, pattern);

            List<string> valid = new List<string>();

            foreach (var match in matches)
            {
                valid.Add(match.ToString());
            }

            for (int i = 0; i < valid.Count; i++)
            {
                string nums = "";
                for (int j = 0; j < valid[i].Length; j++)
                {
                    if (Char.IsDigit(valid[i][j]))
                    {
                        nums += valid[i][j];
                    }
                }
                if (nums.Length % 3 != 0)
                {
                    continue;
                }
                string numPattern = @"[0-9]{3}";
                MatchCollection numMatches = Regex.Matches(nums, numPattern);

                foreach (var match in numMatches)
                {
                    int num = int.Parse(match.ToString());
                    num -= valid[i].Length;
                    char ch = (char)num;
                    output += ch;
                }
            }

            Console.WriteLine(output);
        }
    }
}
