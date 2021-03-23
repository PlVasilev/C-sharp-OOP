using System;
using System.Linq;

namespace Ex05RubiksMatrix
{
    class Ex05RubiksMatrix
    {
        static void Main(string[] args)
        {
            int[] dementions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dementions[0];
            int cols = dementions[1];

            int[][] rubicMatrix = new int[rows][];

            GetMatrix(rubicMatrix, cols);

            int comandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < comandsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");

                int rowColIndex = int.Parse(input[0]);
                string direction = input[1];
                int steps = int.Parse( input[2]);

                switch (direction)
                {
                    case "down":
                        MoveDown(rubicMatrix, rowColIndex, steps % rubicMatrix.Length);
                        break;
                    case "up":
                        MoveUp(rubicMatrix, rowColIndex, steps % rubicMatrix.Length);
                        break;
                    case "left":
                        MoveLeft(rubicMatrix, rowColIndex, steps % rubicMatrix[0].Length);
                        break;
                    case "right":
                        MoveRight(rubicMatrix, rowColIndex, steps % rubicMatrix[0].Length);
                        break;
                    default:
                        break;
                }

            }
            //Print(rubicMatrix);

            int counter = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (rubicMatrix[i][j] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        Rearrange(rubicMatrix, i, j, counter);
                        counter++;
                    }
                }
            }
            //Print(rubicMatrix);
        }

        private static void Rearrange(int[][] rubicMatrix, int row, int col,int counter)
        {
            for (int targetRow = 0; targetRow < rubicMatrix.Length; targetRow++)
            {
                for (int targetCol = 0; targetCol < rubicMatrix[row].Length; targetCol++)
                {
                    if (rubicMatrix[targetRow][targetCol] == counter)
                    {
                        rubicMatrix[targetRow][targetCol] = rubicMatrix[row][col];
                        rubicMatrix[row][col] = counter;
                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
                        return;
                    }
                }
            }
        }

        private static void MoveRight(int[][] rubicMatrix, int row, int steps)
        {      
            for (int i = 0; i < steps; i++)
            {
                int lastElement = rubicMatrix[row][rubicMatrix[row].Length - 1];
                for (int j = rubicMatrix[row].Length - 1 ; j > 0; j--)
                {
                    rubicMatrix[row][j] = rubicMatrix[row][j - 1];
                }
                rubicMatrix[row][0] = lastElement;
            }
        }

        private static void MoveUp(int[][] rubicMatrix, int col, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                int firstElement = rubicMatrix[0][col];
                for (int j = 0; j < rubicMatrix.Length - 1; j++)
                {
                    rubicMatrix[j][col] = rubicMatrix[j + 1][col];
                }
                rubicMatrix[rubicMatrix.Length - 1][col] = firstElement;
            }
        }

        private static void MoveLeft(int[][] rubicMatrix, int row, int steps)
        {
            for (int j = 0; j < steps; j++)
            {
                int firstElement = rubicMatrix[row][0];
                for (int i = 0; i < rubicMatrix[row].Length - 1; i++)
                {
                    rubicMatrix[row][i] = rubicMatrix[row][i + 1];
                }
                rubicMatrix[row][rubicMatrix[row].Length - 1] = firstElement;
            }
           
        }

        private static void MoveDown(int[][] rubicMatrix, int col, int steps)
        {
            for (int j = 0; j < steps; j++)
            {
                int lastElement = rubicMatrix[rubicMatrix.Length - 1][col];
                for (int i = rubicMatrix.Length - 1; i > 0; i--)
                {
                    rubicMatrix[i][col] = rubicMatrix[i - 1][col];
                }
                rubicMatrix[0][col] = lastElement;
            }
            
        }

        private static void Print(int[][] rubicMatrix)
        {
            for (int i = 0; i < rubicMatrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", rubicMatrix[i]));
            }
        }

        private static void GetMatrix(int[][] rubicMatrix, int cols)
        {
            int counter = 1;
            for (int i = 0; i < rubicMatrix.Length; i++)
            {
                rubicMatrix[i] = new int[cols];
                for (int j = 0; j < rubicMatrix[i].Length; j++)
                {
                    rubicMatrix[i][j] = counter++;
                }
            }   
        }
    }
}
