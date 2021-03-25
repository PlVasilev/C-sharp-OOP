using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04OnlineRadioDB
{
    class Ex04OnlineRadioDB
    {
        static void Main(string[] args)
        {
            int songsAdded = 0;
            int totalLeght = 0;
            int songsToAdd = int.Parse(Console.ReadLine());
            for (int i = 0; i < songsToAdd; i++)
            {
                try
                {
                    string[] song = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                    if (song.Length != 3)
                    {
                        throw new ArgumentException("Invalid song.");
                    }
                    else if (song[0].Length < 3 || song[0].Length > 20)
                    {
                        throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                    }
                    else if (song[1].Length < 3 || song[1].Length > 20)
                    {
                        throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                    }
                    else if (!int.TryParse(song[2].Split(":")[0], out int result) && !int.TryParse(song[2].Split(":")[1], out int result2))
                    {
                        throw new ArgumentException("Invalid song length.");
                    }
                    else if (song[2].Split(":").Select(int.Parse).ToArray()[0] > 14 || song[2].Split(":").Select(int.Parse).ToArray()[0] < 0)
                    {
                        throw new ArgumentException("Song minutes should be between 0 and 14.");
                    }
                    else if (song[2].Split(":").Select(int.Parse).ToArray()[1] > 59 || song[2].Split(":").Select(int.Parse).ToArray()[0] < 0)
                    {
                        throw new ArgumentException("Song seconds should be between 0 and 59.");
                    }
                    else
                    {
                        Console.WriteLine("Song added.");
                        songsAdded++;
                        int[] songLeght = song[2].Split(":").Select(int.Parse).ToArray();
                        totalLeght += songLeght[0] * 60 + songLeght[1];

                    }

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                

            }
            Console.WriteLine($"Songs added: {songsAdded}");
            Console.WriteLine($"Playlist length: {Math.Floor(totalLeght / 3600.0)}h {Math.Floor((totalLeght % 3600.0)/ 60) }m {totalLeght % 60}s");
        }
    }
}
