using System;
using System.IO;

namespace Problem1OddLines
{
    class Problem1OddLines
    {
        static void Main(string[] args)
        {
            string path = "../../../../files";
            string fileName = "text.txt";

            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string textLine = reader.ReadLine();
                int counter = 0;
                while (textLine != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(textLine);
                    }
                    counter++;
                    textLine = reader.ReadLine();
                }
                
            }
        }
    }
}
