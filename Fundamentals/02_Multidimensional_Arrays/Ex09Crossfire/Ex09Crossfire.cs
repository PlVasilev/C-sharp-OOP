using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex09Crossfire
{
    class Ex09Crossfire
    {
        static void Main(string[] args)
        {
            int[] dementions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dementions[0];
            int cols = dementions[1];

            string[][] matrix = new string[rows][];

            FillTheMatrix(matrix, rows, cols);

            string command = Console.ReadLine();

            bool result = false;

            while (command != "Nuke it from orbit")
            {
                int[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = commands[0];
                int col = commands[1];
                int radius = commands[2];

                matrix = Nuke(matrix, row, col, radius, rows, cols, result);
                command = Console.ReadLine();
            }

            result = true;
            matrix = GetResultMatrix(matrix, result);
            PrintMatrix(matrix, rows, cols);
        }

        private static string[][] GetResultMatrix(string[][] matrix, bool result)
        {
            Dictionary<int, List<string>> newMatrixDix = new Dictionary<int, List<string>>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != " " && matrix[i][j] != null)
                    {
                        if (!newMatrixDix.ContainsKey(i))
                        {
                            newMatrixDix.Add(i, new List<string>());
                        }
                        newMatrixDix[i].Add(matrix[i][j]);
                    }
                }
            }
            int newMatrixRows = newMatrixDix.Keys.Count;

            string[][] newMatrix = new string[newMatrixRows][];

            int index = 0;
            foreach (var row in newMatrixDix)
            {

                newMatrix[index] = new string[row.Value.Count];

                for (int i = 0; i < row.Value.Count; i++)
                {
                    newMatrix[index][i] = row.Value[i];
                }
                index++;
            }
            matrix = newMatrix;
            return matrix;

        }

        private static string[][] Nuke(string[][] matrix, int row, int col, int radius, int rows, int cols, bool result)
        {
            for (int i = Math.Max(row - radius, 0); i <= Math.Min(row + radius, rows - 1); i++)
            {
                if (i == row)
                {
                    for (int j = Math.Max(col - radius, 0); j <= Math.Min(col + radius, cols - 1); j++)
                    {
                        matrix[i][j] = " ";
                    }
                }
                else if (col >= 0 && col < cols && i >= 0 && i < rows)
                {
                    matrix[i][col] = " ";
                }
            }
            matrix = FillRemainsOfMatrix(matrix, rows, cols, result);
            return matrix;
        }

        private static string[][] FillRemainsOfMatrix(string[][] matrix, int rows, int cols, bool result)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i][j] == " ")
                    {
                        matrix[i][j] = matrix[i][j + 1];
                        matrix[i][j + 1] = " ";
                    }
                }
            }
            return matrix;
        }

        private static void PrintMatrix(string[][] matrix, int rows, int cols)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        private static void FillTheMatrix(string[][] matrix, int rows, int cols)
        {
            int index = 1;
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] != " ")
                    {
                        matrix[i][j] = index.ToString();
                        index++;
                    }
                }
            }
        }
    }
}
