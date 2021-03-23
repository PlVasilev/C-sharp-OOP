using System;
using System.IO;

namespace Problem2LineNumbers
{
    class Problem2LineNumbers
    {
        static void Main(string[] args)
        {
            string path = "../../../../files";
            string fileName = "text.txt";
            string outFile = "resultProb2.txt";

            string path1 = Path.Combine(path, fileName);
            string pathOut = Path.Combine(path, outFile);
            using (StreamReader reader = new StreamReader(path1))
            {
                using (StreamWriter writer = new StreamWriter(pathOut))
                {
                    string textLine = reader.ReadLine();
                    int counter = 0;
                    while (textLine != null)
                    {
                        writer.WriteLine($"Line {++counter}: {textLine}");
                        textLine = reader.ReadLine();
                    }

                }
            }
        }
    }
}
