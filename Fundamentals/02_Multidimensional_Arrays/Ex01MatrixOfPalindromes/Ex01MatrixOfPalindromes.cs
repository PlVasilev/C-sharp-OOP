using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01MatrixOfPalindromes
{
    class Ex01MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] dementions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dementions[0];
            int cols = dementions[1];
            char[] letters = { 'a', 'a', 'a' };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    letters[0] = (char) (letters[0] + i);
                    letters[1] = (char) (letters[1] + i + j);
                    letters[2] = (char) (letters[2] + i);

                    Console.Write(string.Join("", letters));
                    Console.Write(" ");
                    letters[0] ='a';
                    letters[1] ='a';
                    letters[2] ='a';
                }
                Console.WriteLine();
            }
        }
    }
}
