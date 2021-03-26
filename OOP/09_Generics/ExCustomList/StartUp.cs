using System.Linq;

namespace ExCustomList
{
    using System;

    class StartUp
    {
        private static CustomList<string> list = new CustomList<string>();

        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = inputArr[0];
            string[] arguments = inputArr.Skip(1).ToArray();

            while (command != "END")
            {
                command = inputArr[0];
                arguments = inputArr.Skip(1).ToArray();

                switch (command)
                {
                    case "Add":
                        list.Add(arguments[0]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(arguments[0]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(arguments[0]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(arguments[0]), int.Parse(arguments[1]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(arguments[0]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Print":
                        Console.WriteLine(list.Print());
                        break;
                    case "Sort":
                        list.Sort();
                        break;
                    default: return;
                }
                inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
