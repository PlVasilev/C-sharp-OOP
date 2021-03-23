using System;
using System.Linq;

namespace ForeachSumMatrixEl
{
    class ForeachSumMatrixEl
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
               .Split(',', StringSplitOptions.RemoveEmptyEntries)
               .Select(Int32.Parse)
               .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int32.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int sum = 0;
            foreach (var element in matrix)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }
    }
}
