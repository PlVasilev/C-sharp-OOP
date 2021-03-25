using System;
using System.Linq;

namespace Ex01Vehicles
{
    class Ex01Vehicles
    {
        static void Main(string[] args)
        {
            double[] carArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => double.TryParse(x, out double result))
                .Select(double.Parse)
                .ToArray();
            Car car = new Car(carArr[0], carArr[1], carArr[2]);

            double[] truckArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => double.TryParse(x, out double result))
                .Select(double.Parse)
                .ToArray();
            Truck truck = new Truck(truckArr[0], truckArr[1], truckArr[2]);

            double[] busArr = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Where(x => double.TryParse(x, out double result))
               .Select(double.Parse)
               .ToArray();
            Bus bus = new Bus(busArr[0], busArr[1], busArr[2]);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Drive")
                {
                    if (input[1] == "Car")
                    {
                        car.Drive(double.Parse(input[2]), 0.9);
                    }
                    else if (input[1] == "Truck")
                    {
                        truck.Drive(double.Parse(input[2]), 1.6);
                    }
                    else if (input[1] == "Bus")
                    {
                        bus.Drive(double.Parse(input[2]), 1.4);
                    }
                }
                else if (input[0] == "DriveEmpty")
                {
                    bus.Drive(double.Parse(input[2]), 0);
                }
                else
                {

                    if(input[1] == "Car")
                    {
                        car.Refuel(double.Parse(input[2]));
                    }
                    else if (input[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(input[2]));
                    }
                    else if (input[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(input[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuant:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuant:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuant:f2}");
        }
    }
}
