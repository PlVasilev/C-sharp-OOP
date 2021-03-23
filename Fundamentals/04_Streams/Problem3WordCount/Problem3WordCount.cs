using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem3WordCount
{
    class Problem3WordCount
    {
        static void Main(string[] args)
        {
            string path = "../../../../files";
            string fileName = "words.txt";
            string fileName2 = "text.txt";
            string outputFile = "result.txt";
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string path1 = Path.Combine(path, fileName);
            string path2 = Path.Combine(path, fileName2);
            string path3 = Path.Combine(path, outputFile);

            using (StreamReader reader = new StreamReader(path1))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    if (!wordCount.ContainsKey(line))
                    {
                        wordCount.Add(line, 0);
                    }
                    line = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(path2))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    Regex regex = new Regex("[A-Za-z]+");
                    foreach (Match word in regex.Matches(line))
                    {
                        if (wordCount.ContainsKey(word.Value))
                        {
                            wordCount[word.Value]++;
                        }
                    }
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(path3))
            {
                foreach (var item in wordCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
