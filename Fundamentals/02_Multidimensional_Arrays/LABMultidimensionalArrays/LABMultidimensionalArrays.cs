using System;

namespace LABMultidimensionalArrays
{
    class LABMultidimensionalArrays
    {
        static void Main(string[] args)
        { // инициализация 1
            int[,] intMatrix = new int[3, 4]; // инициализира се с дефоутна стойност за инт 0 - пълен е с нули
            float[,] floatMatrix = new float[8, 2]; //  може да се прави операция
            string[,,] stringCube = new string[5, 5, 5]; //дефоутна стойност за стринг null - не може да се прави опарация с null
            // инициализация 2
            int[,] matrix = {
                            {1, 2, 3, 4}, //row 0 values
                            {5, 6, 7, 8}  //row 1 values
                            };
            // Getting element value:
            int[,] array = { { 1, 2 }, { 3, 4 } };
            int element11 = array[1, 1]; //element11 = 4
            // Setting element value
            int[,] array1 = new int[3, 4];
            for (int row = 0; row < array.GetLength(0); row++)
                for (int col = 0; col < array.GetLength(1); col++)
                    array[row, col] = row + col;

            // Foreach iterates through all elements in the matrix

            int[,] matrix1 = {
                             { 5, 2, 3, 1 },
                             { 1, 9, 2, 4 },
                             { 9, 8, 6, 9 }
                             };
            foreach (int element in matrix)
            {
                Console.WriteLine(element);
            }

            //Jagged arrays are multidimensional arrays
            //But each dimension has different size

            int[][] jagged1 = new int[3][];
            jagged1[0] = new int[3];
            jagged1[1] = new int[2];
            int jelement = jagged1[0][0];

            //Filling a Jagged Array
            int[][] jagged = new int[5][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' ');
                jagged[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }
            }

            //Printing а Jagged Array - Example
           
            for (int row = 0; row < matrix.Length; row++)
                for (int col = 0; col < jagged[row].Length; col++)
                    Console.Write("{0} ", jagged[row][col]);
            Console.WriteLine();

            foreach (int[] row in jagged) // обхожда само по основния елемент и връща масива който стои зад него
            {
                Console.WriteLine(string.Join(" ", row));
            }


        }
    }
}
