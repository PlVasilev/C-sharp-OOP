using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07LegoBlocks
{
    class Ex07LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] firstJagged = new int[n][];
            int[][] secondJagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                firstJagged[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int i = 0; i < n; i++)
            {
                secondJagged[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            int combinedMatrixLenght = firstJagged[0].Length + secondJagged[0].Length;
            int[][] combinedMatrix = new int[n][];
            

            bool IsMatrix = true;

            for (int i = 0; i < n; i++)
            {
                if (firstJagged[i].Length + secondJagged[i].Length != combinedMatrixLenght)
                {
                    IsMatrix = false;
                }
            }

            if (IsMatrix == true)
            {
                for (int i = 0; i < n; i++)
                {
                    Stack<int> secondJaggedStack = new Stack<int>();
                    int[] arrToAdd = new int[combinedMatrixLenght];
                    for (int j = 0; j < firstJagged[i].Length; j++)
                    {
                        arrToAdd[j] = firstJagged[i][j];
                    }
                    for (int j = 0; j < secondJagged[i].Length; j++)
                    {
                        secondJaggedStack.Push(secondJagged[i][j]);
                    }
                    for (int j = firstJagged[i].Length; j < combinedMatrixLenght; j++)
                    {
                        int num = secondJaggedStack.Pop();
                        arrToAdd[j] = num;
                    }
                    Console.WriteLine($"[{string.Join(", ",arrToAdd)}]");
                }
            }
            else
            {
                int elements = 0;
                foreach (var item in firstJagged)
                {
                    elements += item.Length;
                }
                foreach (var item in secondJagged)
                {
                    elements += item.Length;
                }
                Console.WriteLine($"The total number of cells is: {elements}");
            }
        }
    }
}
