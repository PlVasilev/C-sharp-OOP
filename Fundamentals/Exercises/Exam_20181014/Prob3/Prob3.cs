using System;
using System.Linq;

namespace Prob3
{
    class Prob3
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char[][] matrix = new char[num][];
            string[] moves = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < num; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }
            // Console.WriteLine();
            int sRow = 0;
            int sCol = 0;
            int totalCoal = 0;
            int colectedCoal = 0;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (matrix[i][j] == 'c')
                    {
                        totalCoal++;
                    }
                }
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (matrix[i][j] == 's')
                    {
                        sRow = i;
                        sCol = j;
                        break;
                    }
                }
            }

            for (int i = 0; i < moves.Length; i++)
            {
                string move = moves[i];
                switch (move)
                {
                    case "left":
                        if (sCol > 0)
                        {
                            if (matrix[sRow][sCol - 1] == 'e')
                            {
                                Console.WriteLine($"Game over! ({sRow}, {sCol - 1})");
                                return;
                            }
                            else if (matrix[sRow][sCol - 1] == 'c')
                            {
                                colectedCoal++;
                                matrix[sRow][sCol - 1] = 's';
                                matrix[sRow][sCol] = '*';
                                sCol = sCol - 1;
                            }
                            else
                            {
                                matrix[sRow][sCol - 1] = 's';
                                matrix[sRow][sCol] = '*';
                                sCol = sCol - 1;
                            }
                        }
                        //  Print(matrix);
                        //  Console.WriteLine();
                        break;
                    case "right":
                        if (sCol < num - 1)
                        {
                            if (matrix[sRow][sCol + 1] == 'e')
                            {
                                Console.WriteLine($"Game over! ({sRow}, {sCol + 1})");
                                return;
                            }
                            else if (matrix[sRow][sCol + 1] == 'c')
                            {
                                colectedCoal++;
                                matrix[sRow][sCol + 1] = 's';
                                matrix[sRow][sCol] = '*';
                                sCol = sCol + 1;
                            }
                            else
                            {
                                matrix[sRow][sCol + 1] = 's';
                                matrix[sRow][sCol] = '*';
                                sCol = sCol + 1;
                            }
                        }
                        //  Print(matrix);
                        //  Console.WriteLine();
                        break;
                    case "up":
                        if (sRow > 0)
                        {
                            if (matrix[sRow - 1][sCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({sRow - 1}, {sCol})");
                                return;
                            }
                            else if (matrix[sRow - 1][sCol] == 'c')
                            {
                                colectedCoal++;
                                matrix[sRow - 1][sCol] = 's';
                                matrix[sRow][sCol] = '*';
                                sRow = sRow - 1;
                            }
                            else
                            {
                                matrix[sRow - 1][sCol] = 's';
                                matrix[sRow][sCol] = '*';
                                sRow = sRow - 1;
                            }
                        }
                        // Print(matrix);
                        // Console.WriteLine();
                        break;
                    case "down":
                        if (sRow < num - 1)
                        {
                            if (matrix[sRow + 1][sCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({sRow + 1}, {sCol})");
                                return;
                            }
                            else if (matrix[sRow + 1][sCol] == 'c')
                            {
                                colectedCoal++;
                                matrix[sRow + 1][sCol] = 's';
                                matrix[sRow][sCol] = '*';
                                sRow = sRow + 1;
                            }
                            else
                            {
                                matrix[sRow + 1][sCol] = 's';
                                matrix[sRow][sCol] = '*';
                                sRow = sRow + 1;
                            }
                        }
                        // Print(matrix);
                        // Console.WriteLine();
                        break;
                    default:
                        break;
                }
                bool noCoalLeft = true;
                for (int j = 0; j < num; j++)
                {
                    if (matrix[j].Contains('c'))
                    {
                        noCoalLeft = false;
                    }
                }
                if (noCoalLeft == true)
                {
                    Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
                    return;
                }

            }
            Console.WriteLine($"{totalCoal - colectedCoal} coals left. ({sRow}, {sCol})");
        }

        private static void Print(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}

