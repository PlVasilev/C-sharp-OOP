using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex08RadioactMutVampBunnies
{
    class Ex08RadioactMutVampBunnies
    {
        static void Main(string[] args)
        {
            int[] matrixDmentions = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int rows = matrixDmentions[0];
            int cols = matrixDmentions[1];

            char[][] matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToArray();

            }

            string playerMovements = Console.ReadLine();

            int playerRow = 0;
            int playerCol = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 'P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            bool won = false;
            bool dead = false;

            for (int i = 0; i < playerMovements.Length; i++)
            {
                if (won != false || dead != false)
                {
                    break;
                }
                char[][] currentMatrix = new char[rows][];
                for (int j = 0; j < rows; j++)
                {
                    currentMatrix[j] = new char[cols];
                }
                char move = playerMovements[i];
                switch (move)
                {
                    case 'R':
                        currentMatrix[playerRow][playerCol] = '.';
                        playerCol++;
                        if (playerCol == cols)
                        {
                            won = true;
                            playerCol--;
                        }
                        break;
                    case 'L':
                        currentMatrix[playerRow][playerCol] = '.';
                        playerCol--;
                        if (playerCol == -1)
                        {
                            playerCol++;
                            won = true;
                        }
                        break;
                    case 'U':
                        currentMatrix[playerRow][playerCol] = '.';
                        playerRow--;
                        if (playerRow == -1)
                        {
                            won = true;
                            playerRow++;
                        }
                        break;
                    case 'D':
                        currentMatrix[playerRow][playerCol] = '.';
                        playerRow++;
                        if (playerRow == rows)
                        {
                            won = true;
                            playerRow--;
                        }
                        break;
                    default:
                        break;
                }

                if (won == true)
                {
                    currentMatrix[playerRow][playerCol] = '.';
                }
                else
                {
                    currentMatrix[playerRow][playerCol] = 'P';
                }
               
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        if (matrix[j][k] == 'B')
                        {
                            currentMatrix[j][k] = 'B';
                            if (j != 0)
                            {
                                if (matrix[j - 1][k] == 'P')
                                {
                                    dead = true;
                                }
                                currentMatrix[j - 1][k] = 'B';
                            }
                            if (j != rows - 1)
                            {
                                if (matrix[j + 1][k] == 'P')
                                {
                                    dead = true;
                                }
                                currentMatrix[j + 1][k] = 'B';
                            }
                            if (k != 0)

                            {
                                if (matrix[j][k - 1] == 'P')
                                {
                                    dead = true;
                                }
                                currentMatrix[j][k - 1] = 'B';
                            }
                            if (k != cols - 1)
                            {
                                if (matrix[j][k + 1] == 'P')
                                {
                                    dead = true;
                                }
                                currentMatrix[j][k + 1] = 'B';
                            }
                        }
                        else if (currentMatrix[j][k] == '\0' && matrix[j][k] == '.')
                        {
                            currentMatrix[j][k] = '.';
                        }
                    }

                }
                matrix = currentMatrix;
            }
            PrintMatrix(matrix, rows, cols, won, dead, playerRow, playerCol);

        }

        private static void PrintMatrix(char[][] matrix, int rows, int cols, bool won, bool dead, int playerRow, int playerCol)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
            if (won == true)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            if (dead == true)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
            Console.WriteLine();
        }
    }
}
