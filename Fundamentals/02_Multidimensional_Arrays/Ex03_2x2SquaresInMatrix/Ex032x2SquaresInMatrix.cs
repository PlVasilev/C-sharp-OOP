using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex032x2SquaresInMatrix
{
    class Ex032x2SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            for (int i = 0; i < matrixSize[0]; i++)
            {
                char[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int squearsCount = 0;

            for (int i = 0; i < matrixSize[0] - 1; i++)
            {
                for (int j = 0; j < matrixSize[1] - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1]
                        && matrix[i, j] == matrix[i + 1, j]
                        && matrix[i, j] == matrix[i + 1, j + 1]
                        )
                    {
                        squearsCount++;
                    }
                }
            }
            Console.WriteLine(squearsCount);
        }
    }
}
