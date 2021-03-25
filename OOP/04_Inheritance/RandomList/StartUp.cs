using System;

namespace RandomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("First");
            list.Add("Second");
            list.Add("Third");
            list.Add("4");
            list.Add("5");
            list.Add("6");

            while (list.Count > 0)
            {
                Console.WriteLine(list.GetRandomElement());
            }
        }
    }
}
