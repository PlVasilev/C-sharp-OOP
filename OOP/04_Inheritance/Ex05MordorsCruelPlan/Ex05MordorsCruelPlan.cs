using System;
using System.Linq;

namespace Ex05MordorsCruelPlan
{
    class Ex05MordorsCruelPlan
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Eat(Console.ReadLine()
                .Split()
                .Where(fn => fn != string.Empty)
                .Select(fn => FoodFactory.GetFood(fn)));

            Console.WriteLine(player);
        }
    }
}
