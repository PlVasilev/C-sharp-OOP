using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07TheVLogger
{
    class Ex07TheVLogger
    {
        static void Main(string[] args)
        {
            // int followers = vloggers.Where(kv => kv.Value.Contains(item.Key)).Count(); count in all in dict
            Dictionary<string, Dictionary<string, SortedSet<string>>> vloggers = 
                new Dictionary<string, Dictionary <string, SortedSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] actionArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vLoggerName = actionArr[0];
                string action = actionArr[1];
                string vLoggerToFollow = "";
                if (vloggers.ContainsKey(vLoggerName) && action == "followed")
                {
                    vLoggerToFollow = actionArr[2];
                    if (vloggers.ContainsKey(vLoggerToFollow) && 
                        vloggers.ContainsKey(vLoggerName) &&
                        vLoggerName != vLoggerToFollow)
                    {
                        vloggers[vLoggerName]["following"].Add(vLoggerToFollow);
                        vloggers[vLoggerToFollow]["followers"].Add(vLoggerName);
                    }
                }
                else
                {
                    if (action == "joined" && !vloggers.ContainsKey(vLoggerName))
                    {
                        vloggers.Add(vLoggerName, new Dictionary<string, SortedSet<string>>());
                        vloggers[vLoggerName].Add("following", new SortedSet<string>());
                        vloggers[vLoggerName].Add("followers", new SortedSet<string>());
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var sortedVloggers = vloggers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count);
            int counter = 0;

            foreach (var item in sortedVloggers)
            {
                 Console.WriteLine($"{++counter}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (counter == 1)
                {
                    foreach (var item1 in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {item1}");
                    }
                }
            }
        }
    }
}
