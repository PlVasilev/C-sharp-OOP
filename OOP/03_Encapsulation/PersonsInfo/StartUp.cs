using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 10);

            Console.WriteLine(pesho.IsAdult()); // cw calls methos toString();

            pesho.SetAge();
            Console.WriteLine(pesho.Age);

            pesho.SetAge(5);
            Console.WriteLine(pesho.Age);
           

            var gosho = new Person("Gosho");
            var currentPerson = gosho.GetMe().SetAge().SetAge(56); // to Chain it MUST return Value;
            Console.WriteLine(currentPerson);
            currentPerson = pesho.GetMe();
            Console.WriteLine(currentPerson);

            pesho.Salary = 2000;

            try
            {
                gosho.Salary = 350;
            }
            catch (ArgumentException ae) // if we dont catch it program ends ...
            {

                Console.WriteLine(ae.Message);
            }

            Console.WriteLine(gosho.Salary);
            Console.WriteLine(pesho.Salary);
            Console.WriteLine();
            pesho.IncreaseSalary(10);

            List<Person> people = new List<Person> // Adding to LIst
            {
                pesho,
                gosho,
                new Person("Sasho" ,67),

            };
            people.Add(new Person("Katiq", 18));
            people.Add(new Person("Katiq", 38));

            people
                .OrderBy(x => x.FirstName2)
                .ThenBy(x => x.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p)); // cuz we overWrote the method toString();

            var inst = new MutableExample();
            Console.WriteLine(inst.Number);

            //  inst.Number = 5; it is mutable so we can not change it 

            inst.Numbers.Add(5); // for referent types we can change read only 
        }
    }
}
