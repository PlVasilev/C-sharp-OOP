using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex8Ranking
{
    class Ex8Ranking
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPass = new Dictionary<string, string>();

            string contest = Console.ReadLine();

            while (contest != "end of contests")
            {
                string[] contestArr = contest.Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (contestArr.Length == 2 && contestArr[0] != null && contestArr[1] != null)
                {
                    if (!contestPass.ContainsKey(contestArr[0]))
                    {
                        contestPass.Add(contestArr[0], contestArr[1]);
                    }
                    else
                    {
                        contestPass[contestArr[0]] = contestArr[1];
                    }
                }
                contest = Console.ReadLine();
            }

            SortedDictionary<string, Dictionary<string, int>> studentRsults = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] inputArr = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string cont = inputArr[0];
                string pass = inputArr[1];
                string user = inputArr[2];
                int score = int.Parse(inputArr[3]);
                if (contestPass.ContainsKey(cont) && contestPass.ContainsValue(pass))
                {
                    if (!studentRsults.ContainsKey(user))
                    {
                        studentRsults.Add(user, new Dictionary<string, int>());
                    }
                    if (!studentRsults[user].ContainsKey(cont))
                    {
                        studentRsults[user].Add(cont, score);
                    }
                    else
                    {
                        if (studentRsults[user][cont] < score)
                        {
                            studentRsults[user][cont] = score;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            string bestStudent = "";
            int bestScore = 0;
            foreach (var item in studentRsults)
            {
                int sum = item.Value.Values.Sum();
                if (bestScore < sum)
                {
                    bestScore = sum;
                    bestStudent = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestStudent} with total {bestScore} points.");
            Console.WriteLine("Ranking: ");
            foreach (var student in studentRsults)
            {
                Console.WriteLine(student.Key);
                var sortedStudent = student.Value.OrderByDescending(x => x.Value);
                foreach (var item in sortedStudent)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
