using System;
using System.Linq;

namespace Ex05AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            
            Console.WriteLine(string.Join("\n", input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length <= n )
                .ToArray())
            );
           

        }
    }
}
