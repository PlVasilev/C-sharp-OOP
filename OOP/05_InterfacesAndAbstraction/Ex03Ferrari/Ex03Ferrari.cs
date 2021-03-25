using System;

namespace Ex03Ferrari
{
    class Ex03Ferrari
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Ferrari ferrari = new Ferrari(name);
            Console.WriteLine($"{Ferrari.model}/{ferrari.PushBreaks()}/{ferrari.PushGas()}/{ferrari.Name}");
        }
    }
}
