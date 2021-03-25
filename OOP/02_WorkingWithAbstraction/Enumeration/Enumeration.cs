using System;

namespace Enumeration
{
    class Enumeration
    {
        static void Main(string[] args)
        {
            //switch (Seasons) // tap tap enum(name) + Enter 
            //{
            //    case Seasons.Autumn:
            //        break;
            //    case Seasons.Spring:
            //        break;
            //    case Seasons.Winter:
            //        break;
            //    case Seasons.Summer:
            //        break;
            //    default:
            //        break;
            //}

            Console.WriteLine(PriceCalculator.Calculate(10, 5, Season.Summer, Discount.VIP));
        }
    }
}
