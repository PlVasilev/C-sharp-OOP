using System;
using System.Linq;

namespace Matrix01DangerousFloor
{
    class Matrix01DangerousFloor
    {
        static void Main(string[] args)
        {
            char[][] matrix = new char[8][];
            for (int i = 0; i < 8; i++)
            {
                matrix[i] = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                char figure = input[0];
                int currRow = input[1] - 48;
                int currCol = input[2] - 48;
                int tarRow = input[4] - 48;
                int tarCol = input[5] - 48;
                bool okMove = true;

                char targetFigure = matrix[currRow][currCol];

                if (targetFigure == figure && tarRow >= 0 && tarRow < 8 && tarCol >= 0 && tarCol < 8)
                {
                    switch (targetFigure)
                    {
                        case 'K':
                            if (matrix[tarRow][tarCol] == 'x' &&
                                (tarRow == currRow - 1 || tarRow == currRow || tarRow == currRow + 1) &&
                                (tarCol == currCol - 1 || tarCol == currCol || tarCol == currCol + 1))
                            {
                                matrix[tarRow][tarCol] = 'K';
                                matrix[currRow][currCol] = 'x';
                            }
                            else
                            {
                                Console.WriteLine("Invalid move!");
                            }
                            break;
                        case 'R':
                            if (matrix[tarRow][tarCol] == 'x' && tarRow == currRow && tarCol != currCol)
                            {
                                for (int i = Math.Min(tarCol, currCol); i <= Math.Max(tarCol, currCol); i++)
                                {
                                    if (matrix[tarRow][i] != 'x' && matrix[tarRow][i] != matrix[currRow][currCol])
                                    {
                                        Console.WriteLine("Invalid move!");
                                        break;
                                    }
                                }
                                if (okMove)
                                {
                                    matrix[tarRow][tarCol] = 'R';
                                    matrix[currRow][currCol] = 'x';
                                }
                            }
                            else if (matrix[tarRow][tarCol] == 'x' && tarCol == currCol && tarRow != currRow)
                            {

                                for (int i = Math.Min(tarRow, currRow); i <= Math.Max(tarRow, currRow); i++)
                                {
                                    if (matrix[i][tarCol] != 'x' && matrix[i][tarCol] != matrix[currRow][currCol])
                                    {
                                        Console.WriteLine("Invalid move!");
                                        okMove = false;
                                        break;
                                    }
                                }
                                if (okMove)
                                {
                                    matrix[tarRow][tarCol] = 'R';
                                    matrix[currRow][currCol] = 'x';
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid move!");
                            }
                            break;
                        case 'B':
                            if (matrix[tarRow][tarCol] == 'x')
                            {
                                if (tarRow < currRow && tarCol < currCol)
                                {
                                    int counter = 1;
                                    while (currRow - counter >= 0 && currCol - counter >= 0)
                                    {
                                        if (matrix[currRow - counter][currCol - counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else if (tarRow > currRow && tarCol > currCol)
                                {
                                    int counter = 1;
                                    while (currRow + counter < 8 && currCol + counter < 8)
                                    {
                                        if (matrix[currRow + counter][currCol + counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else if (tarRow < currRow && tarCol > currCol)
                                {
                                    int counter = +1;
                                    while (currRow - counter >= 0 && currCol + counter < 8)
                                    {
                                        if (matrix[currRow - counter][currCol + counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else if (tarRow > currRow && tarCol < currCol)
                                {
                                    int counter = +1;
                                    while (currRow + counter < 8 && currCol - counter >= 0)
                                    {
                                        if (matrix[currRow + counter][currCol - counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid move!");
                                    okMove = false;
                                }
                                if (okMove)
                                {
                                    matrix[tarRow][tarCol] = 'B';
                                    matrix[currRow][currCol] = 'x';
                                }
                            }
                            break;
                        case 'Q':
                            if (matrix[tarRow][tarCol] == 'x')
                            {
                                if (tarRow < currRow && tarCol < currCol)
                                {
                                    int counter = 1;
                                    while (currRow - counter >= 0 && currCol - counter >= 0)
                                    {
                                        if (matrix[currRow - counter][currCol - counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else if (tarRow > currRow && tarCol > currCol)
                                {
                                    int counter = 1;
                                    while (currRow + counter < 8 && currCol + counter < 8)
                                    {
                                        if (matrix[currRow + counter][currCol + counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else if (tarRow < currRow && tarCol > currCol)
                                {
                                    int counter = +1;
                                    while (currRow - counter >= 0 && currCol + counter < 8)
                                    {
                                        if (matrix[currRow - counter][currCol + counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else if (tarRow > currRow && tarCol < currCol)
                                {
                                    int counter = +1;
                                    while (currRow + counter < 0 && currCol - counter <= 0)
                                    {
                                        if (matrix[currRow + counter][currCol - counter] != 'x')
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                        counter++;
                                    }
                                }
                                else if (matrix[tarRow][tarCol] == 'x' && tarRow == currRow && tarCol != currCol)
                                {
                                    for (int i = Math.Min(tarCol, currCol); i <= Math.Max(tarCol, currCol); i++)
                                    {
                                        
                                        if (matrix[tarRow][i] != 'x' && matrix[tarRow][i] != matrix[currRow][currCol])
                                        {
                                            
                                            Console.WriteLine("Invalid move!");
                                            break;
                                        }
                                    }
                                    if (okMove)
                                    {
                                        matrix[tarRow][tarCol] = 'Q';
                                        matrix[currRow][currCol] = 'x';
                                    }
                                }
                                else if (matrix[tarRow][tarCol] == 'x' && tarCol == currCol && tarRow != currRow)
                                {

                                    for (int i = Math.Min(tarRow, currRow); i <= Math.Max(tarRow, currRow); i++)
                                    {
                                        if (matrix[i][tarCol] != 'x' && matrix[i][tarCol] != matrix[currRow][currCol])
                                        {
                                            Console.WriteLine("Invalid move!");
                                            okMove = false;
                                            break;
                                        }
                                    }
                                }
                                if (okMove)
                                {
                                    matrix[tarRow][tarCol] = 'Q';
                                    matrix[currRow][currCol] = 'x';
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid move!");
                            }
                                break;
                        case 'P':
                            if (matrix[tarRow][tarCol] == 'x' && tarRow == currRow - 1 && tarCol == currCol)
                            {
                                matrix[tarRow][tarCol] = 'P';
                                matrix[currRow][currCol] = 'x';
                            }
                            else
                            {
                                Console.WriteLine("Invalid move!");
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (targetFigure == figure)
                {
                    Console.WriteLine("Move go out of board!");
                }
                else
                {
                    Console.WriteLine("There is no such a piece!");
                }

            }
        }
    }
}
