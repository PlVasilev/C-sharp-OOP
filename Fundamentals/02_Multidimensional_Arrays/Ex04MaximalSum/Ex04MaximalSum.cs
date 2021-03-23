using System;
using System.Linq;

namespace Ex04MaximalSum
{
    class Ex04MaximalSum
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int i = 0; i < matrixSize[0]; i++)
            {
                int[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int sum = int.MinValue;
            int[,] matrixToPrint = new int[3, 3];

            for (int i = 0; i < matrixSize[0] - 2; i++)
            {
                for (int j = 0; j < matrixSize[1] - 2; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                                     matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                                     matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                matrixToPrint[k, l] = matrix[i + k, j + l];
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrixToPrint[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
