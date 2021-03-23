using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06TargetPractice
{
    class Ex06TargetPractice
    {
        static void Main(string[] args)
        {
            int[] dementions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dementions[0];
            int cols = dementions[1];

            string snake = Console.ReadLine();

            int[] shot = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotRow = shot[0];
            int shotCol = shot[1];
            int shotRadius = shot[2];

            char[,] matrix = new char[rows, cols];

            GenerateMatrix(matrix, rows, cols, snake);

            Shot(matrix, shotRow, shotCol, shotRadius,rows,cols);

            RearangeMatrix(matrix, rows, cols);

            PrintMatrix(matrix, rows, cols);
        }

        private static void RearangeMatrix(char[,] matrix, int rows, int cols)
        {
            bool toPrintMatrix = false;
            while (toPrintMatrix == false)
            {
                toPrintMatrix = true;
                for (int i = 1; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] == ' ' && matrix[i - 1, j] != ' ')
                        {
                            matrix[i, j] = matrix[i - 1, j];
                            matrix[i - 1, j] = ' ';
                            toPrintMatrix = false;
                        }
                    }
                }
            }
        }

        private static void Shot(char[,] matrix, int shotRow, int shotCol, int shotRadius, int rows, int cols)
        {

            matrix[shotRow, shotCol] = ' ';
            //Calculate radius
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((row - shotRow) *
                        (row - shotRow) +
                        (col - shotCol) *
                        (col - shotCol)
                        <= shotRadius * shotRadius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
            //int index = Math.Min(shotRow - shotRadius,0);
            //index = Math.Abs(index);
            //
            //for (int i = Math.Max(shotRow - shotRadius, 0); i <= shotRow; i++)
            //{
            //    for (int j = Math.Max(shotCol - index, 0); j <= Math.Min(shotCol + index, cols - 1); j++)
            //    {
            //        matrix[i, j] = ' ';
            //    }
            //    index++;
            //}
            //index--;
            //for (int i = shotRow; i <= Math.Min(shotRow + shotRadius, rows - 1); i++)
            //{
            //    for (int j = Math.Max(shotCol - index, 0); j <= Math.Min(shotCol + index, cols - 1); j++)
            //    {
            //        matrix[i, j] = ' ';
            //    }
            //    index--;
            //}
        }

        private static void PrintMatrix(char[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }
        }

        private static void GenerateMatrix(char[,] matrix, int rows, int cols, string snake)
        {
            int stringIndex = 0;
            bool rightToLeft = true;

            for (int i = rows - 1; i >=0 ; i--)
            {
                if (rightToLeft == true)
                {
                    for (int k = cols - 1; k >= 0; k--)
                    {  
                        matrix[i,k] = snake[stringIndex++ % snake.Length];
                    }
                }
                else
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = snake[stringIndex++ % snake.Length];
                    }
                }
                if (rightToLeft == true)
                {
                    rightToLeft = false;
                }
                else
                {
                    rightToLeft = true;
                }
            }
        }
    }
}
