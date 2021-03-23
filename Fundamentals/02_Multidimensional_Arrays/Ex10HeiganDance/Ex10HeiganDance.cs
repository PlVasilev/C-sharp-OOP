using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex10HeiganDance
{
    class Ex10HeiganDance
    {
        static void Main(string[] args)
        {
            double playerDMG = double.Parse(Console.ReadLine());

            int[,] matrix = new int[15, 15];
            matrix[7, 7] = 2;

            int playerHP = 18500;
            double heiganHP = 3000000;
            string killerSpell = "";
            bool DOT = false;

            while (playerHP > 0 && heiganHP > 0)
            {
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (matrix[i, j] != 2)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
                string[] spellArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string spell = spellArr[0];
                int spellRow = int.Parse(spellArr[1]);
                int spellCow = int.Parse(spellArr[2]);
                heiganHP -= playerDMG;

                if (DOT == true)
                {
                    playerHP -= 3500;
                    killerSpell = "Plague Cloud";
                    DOT = false;
                }

                if (heiganHP <= 0)
                {
                    break;
                }

                if (playerHP <= 0)
                {
                    break;
                }

                int mustEscapeRow = 0;
                int mustEscapeCol = 0;
                bool mustEscape = false;
                for (int i = spellRow - 1; i <= spellRow + 1; i++)
                {
                    for (int j = spellCow - 1; j <= spellCow + 1; j++)
                    {
                        if (i >= 0 && i < 15 && j >= 0 && j < 15)
                        {
                            if (matrix[i, j] == 2)
                            {
                                mustEscapeRow = i;
                                mustEscapeCol = j;
                                matrix[i, j] = 1;
                                mustEscape = true;
                            }
                            else
                            {
                                matrix[i, j] = 1;
                            }

                        }
                    }
                }

                bool escaped = true;

                if (mustEscape == true)
                {
                    if (mustEscapeRow - 1 >= 0 && matrix[mustEscapeRow - 1, mustEscapeCol] == 0)
                    {
                        matrix[mustEscapeRow - 1, mustEscapeCol] = 2;
                        escaped = true;
                    }
                    else if (mustEscapeCol + 1 < 15 && matrix[mustEscapeRow, mustEscapeCol + 1] == 0)
                    {
                        matrix[mustEscapeRow, mustEscapeCol + 1] = 2;
                        escaped = true;
                    }
                    else if (mustEscapeRow + 1 < 15 && matrix[mustEscapeRow + 1, mustEscapeCol] == 0)
                    {
                        matrix[mustEscapeRow + 1, mustEscapeCol] = 2;
                        escaped = true;
                    }
                    else if (mustEscapeCol - 1 >= 0 && matrix[mustEscapeRow, mustEscapeCol - 1] == 0)
                    {
                        matrix[mustEscapeRow, mustEscapeCol - 1] = 2;
                        escaped = true;
                    }
                    else
                    {
                        matrix[mustEscapeRow, mustEscapeCol] = 2;
                        escaped = false;
                        mustEscape = false;
                    }
                }
                if (escaped == false)
                {
                    if (spell == "Eruption")
                    {
                        playerHP -= 6000;
                        killerSpell = "Eruption";
                    }
                    else
                    {
                        playerHP -= 3500;
                        killerSpell = "Plague Cloud";
                        DOT = true;
                    }
                    if (playerHP <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    escaped = false;
                }

            }

            if (heiganHP <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
                if (playerHP <= 0)
                {
                    Console.WriteLine($"Player: Killed by {killerSpell}");
                }
                else
                {
                    Console.WriteLine($"Player: {playerHP}");
                }
               
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (matrix[i, j] == 2)
                        {
                            Console.WriteLine($"Final position: {i}, {j}");
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine($"Heigan: {heiganHP:f2}");
                Console.WriteLine($"Player: Killed by {killerSpell}");
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (matrix[i, j] == 2)
                        {
                            Console.WriteLine($"Final position: {i}, {j}");
                        }
                    }
                }
            }

        }
    }
}
