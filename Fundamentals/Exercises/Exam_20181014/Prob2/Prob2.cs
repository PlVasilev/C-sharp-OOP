using System;
using System.Collections.Generic;
using System.Linq;

namespace Prob2
{
    class Prob2
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> usersTotalLikes = new Dictionary<string,  int>();

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                if (input.StartsWith("ban"))
                {
                    string user = input.Substring(4, input.Length - 4);
                    if (users.ContainsKey(user))
                    {
                        users.Remove(user);
                    }
                }
                else
                {
                    string[] usersArr = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string user = usersArr[0];
                    string tag = usersArr[1];
                    int likes = int.Parse(usersArr[2]);
                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, new Dictionary<string, int>());
                    }
                    if (!users[user].ContainsKey(tag))
                    {
                        users[user].Add(tag, likes);
                    }
                    else
                    {
                        users[user][tag] += likes;
                    }
                }
            }
            foreach (var user in users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Value.Values.Count))
            {
                Console.WriteLine(user.Key);
                foreach (var tags in user.Value)
                {
                    Console.WriteLine($"- {tags.Key}: {tags.Value}");
                }
            }

        }
    }
}
