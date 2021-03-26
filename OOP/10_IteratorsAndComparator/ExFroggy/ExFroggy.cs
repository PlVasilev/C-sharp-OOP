using System;
using System.Linq;

namespace ExFroggy
{
    public class ExFroggy
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Lake lake = new Lake();

            for (int i = 0; i < input.Length; i++)
            {
                Stone stone = new Stone(input[i]);
                lake.AddStone(stone);
            }

            Console.WriteLine(string.Join(", ", lake.Jump().Select(x => x.Number)));


        }
    }
}
