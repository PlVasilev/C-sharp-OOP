using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02DiagonalDifference
{
    class Ex02DiagonalDifference
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                int[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int firsrDiagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (i == j)
                    {
                        firsrDiagonal += matrix[i, j];
                    }
                    if (i + j == matrixSize - 1)
                    {
                        secondDiagonal += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(firsrDiagonal-secondDiagonal));
        }
    }
}
