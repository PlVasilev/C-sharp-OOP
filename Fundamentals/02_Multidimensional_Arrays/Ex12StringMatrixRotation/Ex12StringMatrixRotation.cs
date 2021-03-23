using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex12StringMatrixRotation
{
    class Ex12StringMatrixRotation
    {
        static void Main(string[] args)
        {
            string rotation = Console.ReadLine();
            Regex regex = new Regex("[0-9]+");
            Match match = regex.Match(rotation);
            int deg = int.Parse(match.Value) % 360;
            List<char[]> jaggedArr = new List<char[]>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                char[] arr = input.ToArray();
                jaggedArr.Add(arr);
                input = Console.ReadLine();
            }

            

            int longestRow = 0; 
            for (int i = 0; i < jaggedArr.Count; i++)
            {
                if (jaggedArr[i].Length > longestRow)
                {
                    longestRow = jaggedArr[i].Length;
                }
            }

            if (deg  == 0)
            {
                char[][] jagged = new char[jaggedArr.Count][];
                for (int i = 0; i < jaggedArr.Count; i++)
                {
                    jagged[i] = new char[longestRow];
                    for (int j = 0; j < jaggedArr[i].Length; j++)
                    {
                        jagged[i][j] = jaggedArr[i][j];
                    }
                    for (int j = jaggedArr[i].Length; j < longestRow; j++)
                    {
                        jagged[i][j] = ' ';
                    }
                }
                for (int i = 0; i < jagged.Length; i++)
                {
                    Console.WriteLine(string.Join("", jagged[i]));
                }
            }
            else if (deg  == 90)
            {
                char[][] jagged = new char[jaggedArr.Count][];
                for (int i = 0; i < jaggedArr.Count; i++)
                {
                    jagged[i] = new char[longestRow];
                    for (int j = 0; j < jaggedArr[i].Length; j++)
                    {
                        jagged[i][j] = jaggedArr[i][j];
                    }
                    for (int j = jaggedArr[i].Length; j < longestRow; j++)
                    {
                        jagged[i][j] = ' ';
                    }
                }

                char[][] juggedToPrint = new char[longestRow][];
                for (int i = 0; i < longestRow; i++)
                {
                    juggedToPrint[i] = new char[jagged.Length];
                    for (int j = 0; j < jagged.Length; j++)
                    {
                        juggedToPrint[i][j] = jagged[j][i];
                    }
                }
                for (int i = 0; i < juggedToPrint.Length; i++)
                {
                    char[] reversed = juggedToPrint[i];
                    Console.WriteLine(string.Join("", reversed.Reverse()));
                }
            }
            else if (deg == 180)
            {
                char[][] jagged = new char[jaggedArr.Count][];
                for (int i = 0; i < jaggedArr.Count; i++)
                {
                    jagged[i] = new char[longestRow];
                    for (int j = 0; j < jaggedArr[jaggedArr.Count - i - 1].Length; j++)
                    {
                        jagged[i][j] = jaggedArr[jaggedArr.Count - i - 1][j];
                    }
                    for (int j = jaggedArr[jaggedArr.Count - i - 1].Length; j < longestRow; j++)
                    {
                        jagged[i][j] = ' ';
                    }
                }
                for (int i = 0; i < jagged.Length; i++)
                {
                    char[] reversed = jagged[i];
                    Console.WriteLine(string.Join("", reversed.Reverse()));
                }
               
            }
            else if (deg == 270)
            {
                char[][] jagged = new char[jaggedArr.Count][];
                for (int i = 0; i < jaggedArr.Count; i++)
                {
                    jagged[i] = new char[longestRow];
                    for (int j = 0; j < jaggedArr[jaggedArr.Count - i - 1].Length; j++)
                    {
                        jagged[i][j] = jaggedArr[jaggedArr.Count - i - 1][j];
                    }
                    for (int j = jaggedArr[jaggedArr.Count - i - 1].Length; j < longestRow; j++)
                    {
                        jagged[i][j] = ' ';
                    }
                }
                char[][] juggedToPrint = new char[longestRow][];
                for (int i = 0; i < longestRow; i++)
                {
                    juggedToPrint[i] = new char[jagged.Length];
                    for (int j = 0; j < jagged.Length; j++)
                    {
                        juggedToPrint[i][j] = jagged[j][i];
                    }
                }
                for (int i = juggedToPrint.Length-1; i >= 0; i--)
                {
                    char[] reversed = juggedToPrint[i];
                    Console.WriteLine(string.Join("", reversed.Reverse()));
                }
            }

        }
    }
}
