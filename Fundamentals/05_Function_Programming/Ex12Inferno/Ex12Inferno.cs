using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex12Inferno
{
    class Ex12Inferno
    {
        static void Main(string[] args)
        {
            Action<List<int>> print = p => Console.WriteLine(string.Join(" ",p));

            Dictionary<string, Dictionary<int, Func<int, int, bool>>> filters =
                new Dictionary<string, Dictionary<int, Func<int, int, bool>>>();

            List<int> initial = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "Forge")
            {
                string[] commandArg = input.Split(';');
                string command = commandArg[0];
                string functionName = commandArg[1];
                int value = int.Parse(commandArg[2]);

                Func<int, int, bool> sumFunc = GetFunction(initial, functionName);

                if (command == "Exclude")
                {
                    if (!filters.ContainsKey(functionName))
                    {
                        filters.Add(functionName, new Dictionary<int, Func<int, int, bool>>());
                    }

                    if (!filters[functionName].ContainsKey(value))
                    {
                        filters[functionName].Add(value, sumFunc);
                    }

                }
                else
                {
                    if (filters.ContainsKey(functionName))
                    {
                        filters[functionName].Remove(value);
                    }
                }
                input = Console.ReadLine();

            }

            List<int> result = new List<int>();

            for (int i = 0; i < initial.Count; i++)
            {
                bool isValue = true;

                foreach (var filter in filters)
                {
                    foreach (var kvp in filter.Value)
                    {
                        if (kvp.Value(i, kvp.Key))
                        {
                            isValue = false;
                            break;
                        }
                    }
                }
                if (isValue)
                {
                    result.Add(initial[i]);
                }
            }
            print(result);
        }

        private static Func<int, int, bool> GetFunction(List<int> numbers, string functionName)
        {
            if (functionName == "Sum Left") 
            {
                return (i, targetSum) => i == 0 ? numbers[i] == targetSum : numbers[i] + numbers[i - 1] == targetSum;
            }
            else if (functionName == "Sum Right")
            {
                return (i, targetSum) => i == numbers.Count - 1 ? numbers[i] == targetSum : numbers[i] + numbers[i - 1] == targetSum;
            }
            else if (functionName == "Sum Left Right")
            {
                return (i, targetSum) => numbers.Count == 1 ? numbers[i] == targetSum :
                                i == numbers.Count -1 ? numbers[i - 1] + numbers[i] == targetSum:
                                i == 0  ? numbers[i] + numbers[i + 1] == targetSum:
                                 numbers[i - 1] + numbers[i] + numbers[i + 1] == targetSum;
            }
            return null;
        }
    }
}
