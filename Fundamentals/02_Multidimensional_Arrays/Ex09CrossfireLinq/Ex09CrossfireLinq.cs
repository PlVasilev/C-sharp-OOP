using System;
using System.Linq;

namespace Ex09CrossfireLinq
{
    class Ex09CrossfireLinq
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix = new int[dimensions[0]][];

            int number = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[dimensions[1]];

                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row][col] = number++;
                }
            }

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Nuke it from orbit")
                {
                    break;
                }

                int[] parameters = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int targetRow = parameters[0];
                int targetCol = parameters[1];
                int range = parameters[2];

                for (int row = targetRow - range; row <= targetRow + range; row++)
                {
                    if (indicesAreInRange(row, targetCol, matrix))
                    {
                        matrix[row][targetCol] = 0;
                    }
                }

                for (int col = targetCol - range; col <= targetCol + range; col++)
                {
                    if (indicesAreInRange(targetRow, col, matrix))
                    {
                        matrix[targetRow][col] = 0;
                    }
                }

                for (int index = 0; index < matrix.Length; index++)
                {
                    if (matrix[index].Any(e => e == 0))
                    {
                        matrix[index] = matrix[index].Where(e => e != 0).ToArray();
                    }
                }

                matrix = matrix.Where(arr => arr.Count() != 0).ToArray();
                foreach (int[] array in matrix)
                {
                    Console.WriteLine(string.Join(" ", array));
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }

            foreach (int[] array in matrix)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
        private static bool indicesAreInRange(int row, int col, int[][] matrix)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
    }
}
