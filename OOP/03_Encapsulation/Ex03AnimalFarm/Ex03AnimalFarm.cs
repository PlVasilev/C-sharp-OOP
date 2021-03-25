using System;

namespace Ex03AnimalFarm
{
    class Ex03AnimalFarm
    {
        static void Main(string[] args)
        {
            try
            {
                Chicken chicken = new Chicken(Console.ReadLine(), int.Parse(Console.ReadLine()));
                Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            

            
        }
    }
}
