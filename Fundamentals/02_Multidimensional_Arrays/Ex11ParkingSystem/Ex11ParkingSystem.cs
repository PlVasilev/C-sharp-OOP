using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex11ParkingSystem
{
    class Ex11ParkingSystem
    {
        static void Main(string[] args)
        {
            int[] parikingDemntons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[parikingDemntons[0], parikingDemntons[1]];

            string input = Console.ReadLine();

            while (input?.ToLower() != "stop")
            {
                int[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int entryRow = inputArr[0];
                int parkRow = inputArr[1];
                int parkCol = inputArr[2];
                bool canPark = false;

                if (matrix[parkRow, parkCol] == 0)
                {
                    canPark = true;
                }
                else
                {
                    while (true)
                    {
                        int abaibleSpotOnRowA = int.MaxValue;
                        int abaibleSpotOnRowB = int.MaxValue;
                        int distanceA = int.MaxValue;
                        int distanceB = int.MaxValue;

                        for (int i = parkCol; i > 0; i--)
                        {
                            if (matrix[parkRow, i] == 0)
                            {
                                distanceA = parkCol - i;
                                abaibleSpotOnRowA = i;
                                canPark = true;
                                break;
                            }
                        }
                        for (int i = parkCol; i < matrix.GetLength(1); i++)
                        {
                            if (matrix[parkRow, i] == 0)
                            {
                                distanceB = i - parkCol;
                                abaibleSpotOnRowB = i;
                                canPark = true;
                                break;
                            }
                        }
                        if (distanceA == distanceB)
                        {
                            parkCol = abaibleSpotOnRowA;
                            break;
                        }
                        else if (distanceA < distanceB)
                        {
                            parkCol = abaibleSpotOnRowA;
                            break;
                        }
                        else
                        {
                            parkCol = abaibleSpotOnRowB;
                            break;
                        }   
                    }
                }

                if (canPark == false)
                {
                    Console.WriteLine($"Row {parkRow} full");
                    
                }
                else
                {
                    matrix[parkRow, parkCol] = 1;
                    Console.WriteLine(Math.Abs(entryRow - parkRow) + parkCol + 1);
                }
                input = Console.ReadLine();
            }
        }
    }
}
