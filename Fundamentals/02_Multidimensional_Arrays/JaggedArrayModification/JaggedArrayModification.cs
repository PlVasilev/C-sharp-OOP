using System;
using System.Linq;

namespace JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[i] = currentRow;
            }
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0]?.ToLower() != "end")
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (int.Parse(input[1]) < 0 ||
                    int.Parse(input[1]) > jagged.Length - 1 ||
                    int.Parse(input[2]) < 0 ||
                    int.Parse(input[2]) > jagged[int.Parse(input[1])].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                switch (input[0]?.ToLower()) // ? проверява дали променливате пред него е null 
                                             // ако е null без ? получаваме exception с ? получавеме си null
                {
                    case "add":
                        jagged[row][col] += value;
                        break;
                    case "subtract":
                        jagged[row][col] -= value;
                        break;
                    default:
                       // Console.WriteLine("Invalid command!");
                        break;
                }
                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in jagged)
            {
                Console.WriteLine(String.Join(' ', item));
            }
        }
    }
}
