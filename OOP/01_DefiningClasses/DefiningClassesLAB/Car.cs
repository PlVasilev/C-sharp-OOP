using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        //public string Model { get; set; }
        //public double Fuel { get; set; }
        //public double Consumption { get; set; }
        //public double Milage { get; set; }
        //
        //public Car(string model, double fuel, double consumtion)
        //{
        //    Model = model;
        //    Fuel = fuel;
        //    Consumption = consumtion;
        //    Milage = 0;
        //}
        //
        //public void Move(double distance)
        //{
        //    if (distance*this.Consumption > this.Fuel)
        //    {
        //        Console.WriteLine("Insufficient fuel for the drive");
        //    }
        //    else
        //    {
        //        this.Milage += distance;
        //        this.Fuel -= distance * this.Consumption;
        //    }
        //}

        //public string Model { get; set; }
        //public Engine Engine { get; set; }
        //public cargo Cargo { get; set; }
        //public tire Tire { get; set; }
        //
        //public Car(string model, Engine engine,cargo cargo, tire tire)
        //{
        //    Model = model;
        //    Engine = engine;
        //    Cargo = cargo;
        //    Tire = tire;
        //}


        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = "n/a";
        }
        
        
        public Car(string model, Engine engine, string prop3)
        {
            Model = model;
            Engine = engine;
            int weight = 0;
            if (int.TryParse(prop3, out weight))
            {
                Weight = prop3;
                Color = "n/a";
            }
            else
            {
                Weight = "n/a";
                Color = prop3;
            }
        }
        
        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        //public string Model { get; set; }
        //public string Speed { get; set; }
        //public Car(string model, string speed)
        //{
        //    Model = model;
        //    Speed = speed;
        //}
    }
}
