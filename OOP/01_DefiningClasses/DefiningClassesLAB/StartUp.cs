using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Problem 3.Oldest Family Member
            //Family family = new Family();
            //
            //int n = int.Parse(Console.ReadLine());
            //
            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    string name = input[0];
            //    int age = int.Parse(input[1]);
            //
            //    Person person = new Person(name, age);
            //    family.AddMember(person);
            //}
            //Person oldestPerson = family.GetOldestMember();
            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

            //Problem 4. Opinion Poll
            //family.People
            //    .Where(x => x.Age > 30)
            //    .OrderBy(x => x.Name)
            //    .ToList()
            //    .ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));

            //Problem 5. Date Modifier
            //DateModifier date = new DateModifier();
            //date.getDays(Console.ReadLine(), Console.ReadLine());

            //Problem 6. Company Roster
            //Dictionary<string, List<Employee>> rooster = new Dictionary<string, List<Employee>>();
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    string name = input[0];
            //    double salary = double.Parse(input[1]);
            //    string position = input[2];
            //    string department = input[3];
            //    if (input.Length == 5)
            //    {
            //        int age;
            //        if (int.TryParse(input[4], out age))
            //        {
            //            if (!rooster.ContainsKey(department))
            //            {
            //                rooster.Add(department, new List<Employee>());
            //            }
            //            Employee employee = new Employee(name, salary, position, department, age);
            //            rooster[department].Add(employee);
            //        }
            //        else
            //        {
            //            if (!rooster.ContainsKey(department))
            //            {
            //                rooster.Add(department, new List<Employee>());
            //            }
            //            Employee employee = new Employee(name, salary, position, department, input[4]);
            //            rooster[department].Add(employee);
            //        }
            //    }
            //    else if (input.Length == 6)
            //    {
            //        if (!rooster.ContainsKey(department))
            //        {
            //            rooster.Add(department, new List<Employee>());
            //        }
            //        Employee employee = new Employee(name, salary, position, department, input[4], int.Parse(input[5]));
            //        rooster[department].Add(employee);
            //    }
            //    else
            //    {
            //        if (!rooster.ContainsKey(department))
            //        {
            //            rooster.Add(department, new List<Employee>());
            //        }
            //        Employee employee = new Employee(name, salary, position, department);
            //        rooster[department].Add(employee);
            //    }
            //    
            //
            //}
            //var result = rooster.OrderByDescending(x => x.Value.Sum(y => y.Salary)).FirstOrDefault();
            //Console.WriteLine($"Highest Average Salary: {result.Key}");
            //
            //result.Value
            //.OrderByDescending(x => x.Salary)
            //.ToList()
            //.ForEach(x => Console.WriteLine($"{x.Name} {x.Salary:f2} {x.Email} {x.Age}"));

            //Problem 7. Speed Racing
            //List<Car> cars = new List<Car>();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
            //    cars.Add(car);
            //}
            //string drive;
            //while ((drive = Console.ReadLine()) != "End")
            //{
            //   string[] input = drive.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    foreach (var car in cars)
            //    {
            //        if (car.Model == input[1])
            //        {
            //            car.Move(double.Parse(input[2]));
            //        }
            //    }
            //}
            //cars.ForEach(x => Console.WriteLine($"{x.Model} {x.Fuel:f2} {x.Milage}"));

            // Problem 8.Raw Data
            //List<Car> cars = new List<Car>();
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 0; i < n; i++)
            // {
            //     string[] carArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //     Engine engine = new Engine(int.Parse(carArr[1]), int.Parse(carArr[2]));
            //     cargo cargo = new cargo(int.Parse(carArr[3]), carArr[4]);
            //     tire tire = new tire(double.Parse(carArr[5]), double.Parse(carArr[7]), double.Parse(carArr[9]), double.Parse(carArr[11]));
            //
            //     Car car = new Car(carArr[0], engine, cargo, tire);
            //     cars.Add(car);
            // }
            //
            // string cargo1 = Console.ReadLine();
            // if (cargo1 == "flamable")
            // {
            //     cars.Where(x => x.Engine.Power > 250 && x.Cargo.Type == "flamable").ToList().ForEach(x => Console.WriteLine($"{x.Model}"));
            // }
            // else if (cargo1 == "fragile")
            // {
            //     cars.Where(x => (x.Tire.Pressure1 < 1 || x.Tire.Pressure2 < 1 || x.Tire.Pressure3 < 1 || x.Tire.Pressure4 < 1)
            //     && x.Cargo.Type == "fragile").ToList().ForEach(x => Console.WriteLine($"{x.Model}"));
            // }

            //Problem 9.Rectangle Intersection
            //    Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();
            //
            //    int[] numArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    for (int i = 0; i < numArr[0]; i++)
            //    {
            //        string[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //        string id = inputArr[0];
            //        double width = Math.Abs(double.Parse(inputArr[1]));
            //        double height = Math.Abs(double.Parse(inputArr[2]));
            //        double pointX = double.Parse(inputArr[3]);
            //        double pointY = double.Parse(inputArr[4]);
            //
            //        Point point = new Point(pointX, pointY);
            //        Point point1 = new Point(pointX + width, pointY - height);
            //        Rectangle rectangle = new Rectangle(id, point, point1);
            //
            //
            //        rectangles.Add(id, rectangle);
            //
            //    }
            //
            //    for (int i = 0; i < numArr[1]; i++)
            //    {
            //        string[] rectanglesToCompair = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //        Console.WriteLine(DoesIntercept(rectangles[rectanglesToCompair[0]], rectangles[rectanglesToCompair[1]]).ToString().ToLower());
            //    }
            //}
            //
            //private static bool DoesIntercept(Rectangle r1, Rectangle r2)
            //{
            //    if (r1.TopLeft.PointX > r2.BotRight.PointX || r2.TopLeft.PointX > r1.BotRight.PointX)
            //    {
            //        return false;
            //    }
            //    if (r1.TopLeft.PointY < r2.BotRight.PointY || r2.BotRight.PointY > r1.TopLeft.PointY )
            //    {
            //        return false;
            //    }
            //
            //    return true;

            //Problem 10. Car Salesman
            // Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            // int num = int.Parse(Console.ReadLine());
            // for (int i = 0; i < num; i++)
            // {
            //     string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //
            //     if (input.Length == 2)
            //     {
            //         Engine engine = new Engine(input[0], input[1]);
            //         engines.Add(input[0], engine);
            //     }
            //     else if (input.Length == 3)
            //     {
            //         Engine engine = new Engine(input[0], input[1],input[2]);
            //         engines.Add(input[0],engine);
            //     }
            //     else
            //     {
            //         Engine engine = new Engine(input[0], input[1], input[2],input[3]);
            //         engines.Add(input[0],engine);
            //     }
            // }
            // num = int.Parse(Console.ReadLine());
            // List<Car> cars = new List<Car>();
            //
            // for (int i = 0; i < num; i++)
            // {
            //     string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //
            //     if (input.Length == 2)
            //     {
            //         Car car = new Car(input[0], engines[input[1]]);
            //         cars.Add(car);
            //     }
            //     else if (input.Length == 3)
            //     {
            //         Car car = new Car(input[0], engines[input[1]], input[2]);
            //         cars.Add(car);
            //     }
            //     else
            //     {
            //         Car car = new Car(input[0], engines[input[1]], input[2], input[3]);
            //         cars.Add(car);
            //     }
            // }
            // foreach (var car in cars)
            // {
            //     Console.WriteLine($"{car.Model}:");
            //     Console.WriteLine($"  {car.Engine.Model}:");
            //     Console.WriteLine($"    Power: {car.Engine.Power}");
            //     Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            //     Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            //     Console.WriteLine($"  Weight: {car.Weight}");
            //     Console.WriteLine($"  Color: {car.Color}");
            // }

            //Problem 11. Pokemon Trainer
            //Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            //string input = Console.ReadLine();
            //
            //while (input != "Tournament")
            //{
            //    string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    string currentTrainer = inputArr[0];
            //    Pokemon pokemon = new Pokemon(inputArr[1], inputArr[2], int.Parse(inputArr[3]));
            //    if (!trainers.ContainsKey(currentTrainer))
            //    {
            //        Trainer trainer = new Trainer(inputArr[0], pokemon);
            //        trainers.Add(currentTrainer, trainer);
            //    }
            //    else
            //    {
            //        trainers[currentTrainer].Pokemons.Add(pokemon);
            //    }
            //    input = Console.ReadLine();
            //}
            //input = Console.ReadLine();
            //while (input != "End")
            //{
            //    foreach (var item in trainers)
            //    {
            //       Trainer trainer = item.Value;
            //        if (trainer.Pokemons.Where(x => x.Element == input).ToArray().Length > 0)
            //        {
            //            trainer.Badges++;
            //        }
            //        else
            //        {
            //            trainers[item.Key].Pokemons = trainers[item.Key].Pokemons.Where(x => x.Health - 10 > 0).ToList();
            //            trainer.Pokemons.ForEach(x => x.Health -= 10);
            //        }
            //    }
            //    input = Console.ReadLine();
            //}
            //
            //foreach (var item in trainers.OrderByDescending(x => x.Value.Badges))
            //{
            //    Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            //}

            //Problem 12. Google
            //Dictionary<string, Person> people = new Dictionary<string, Person>();
            //
            //string input = Console.ReadLine();
            //
            //while (input != "End")
            //{
            //    string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    string name = inputArr[0];
            //    if (!people.ContainsKey(name))
            //    {
            //        people.Add(name, new Person(name));
            //    }
            //    string infoType = inputArr[1];
            //    switch (infoType)
            //    {
            //        case "company":
            //            people[name].Company = new Company(inputArr[2], inputArr[3], decimal.Parse(inputArr[4]));
            //            break;
            //        case "pokemon":
            //            Pokemon pokemon = new Pokemon(inputArr[2], inputArr[3]);
            //            people[name].Pokemons.Add(pokemon);
            //            break;
            //        case "parents":
            //            Parent parent = new Parent(inputArr[2], inputArr[3]);
            //            people[name].Parents.Add(parent);
            //            break;
            //        case "children":
            //            Child child = new Child(inputArr[2], inputArr[3]);
            //            people[name].Children.Add(child);
            //            break;
            //        case "car":
            //            people[name].Car = new Car(inputArr[2], inputArr[3]);
            //            break;
            //        default:
            //            break;
            //    }
            //    input = Console.ReadLine();
            //}
            //input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.WriteLine($"Company:");
            //if (people[input].Company != null)
            //{
            //    Console.WriteLine($"{people[input].Company.Name} {people[input].Company.Department} {people[input].Company.Salary:f2}");
            //}
            //Console.WriteLine($"Car:");
            //if (people[input].Car != null)
            //{
            //    Console.WriteLine($"{people[input].Car.Model} {people[input].Car.Speed}");
            //}
            //Console.WriteLine($"Pokemon:");
            //if (people[input].Pokemons.Count > 0)
            //{
            //    people[input].Pokemons.ForEach(x => Console.WriteLine($"{x.Name} {x.Type}"));
            //}
            //Console.WriteLine($"Parents:");
            //if (people[input].Parents.Count > 0)
            //{
            //    people[input].Parents.ForEach(x => Console.WriteLine($"{x.Name} {x.BirthDay}"));
            //}
            //Console.WriteLine($"Children:");
            //if (people[input].Children.Count > 0)
            //{
            //    people[input].Children.ForEach(x => Console.WriteLine($"{x.Name} {x.BirthDay}"));
            //}

            //Problem 13.Family Tree

            var searchedPerson = Console.ReadLine();
            var allPeople = new List<Person>();
            CollectData(allPeople);
            PrintParentsAndChildren(allPeople, searchedPerson);
        }

        private static void PrintParentsAndChildren(List<Person> allPeople, string searchedPersonParam)
        {
            var person = allPeople.FirstOrDefault(p => (searchedPersonParam.Contains("/"))
                ? p.BirthDate == searchedPersonParam
                : p.Name == searchedPersonParam);

            var result = new StringBuilder();
            result.AppendLine($"{person.Name} {person.BirthDate}");

            result.AppendLine("Parents:");
            foreach (var parent in allPeople.Where(p => p.FindChildName(person.Name) != null))
            {
                result.AppendLine($"{parent.Name} {parent.BirthDate}");
            }

            result.AppendLine("Children:");
            foreach (var child in allPeople.FirstOrDefault(p => p.Name == person.Name).Children)
            {
                result.AppendLine($"{child.Name} {child.BirthDate}");
            }

            Console.WriteLine(result);
        }

        private static void CollectData(List<Person> allPeople)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine.Contains("-"))
                {
                    var tokens = inputLine
                        .Split('-')
                        .Select(x => x.Trim())
                        .ToArray();

                    var parentParam = tokens[0];
                    var childParam = tokens[1];

                    // Parent
                    var parent = allPeople.FirstOrDefault(p => (parentParam.Contains("/"))
                        ? p.BirthDate == parentParam
                        : p.Name == parentParam);

                    if (parent == null)
                    {
                        parent = (parentParam.Contains("/"))
                            ? new Person { BirthDate = parentParam }
                            : new Person { Name = parentParam };

                        allPeople.Add(parent);
                    }

                    // Child
                    var child = (childParam.Contains("/"))
                        ? new Person { BirthDate = childParam }
                        : new Person { Name = childParam };

                    parent.AddChild(child);
                }
                else
                {
                    var tokens = inputLine.Split(' ');

                    var name = $"{tokens[0]} {tokens[1]}";
                    var date = tokens[2];
                    var added = false;

                    for (int i = 0; i < allPeople.Count; i++)
                    {
                        if (allPeople[i].Name == name)
                        {
                            allPeople[i].BirthDate = date;
                            added = true;
                        }

                        if (allPeople[i].BirthDate == date)
                        {
                            allPeople[i].Name = name;
                            added = true;
                        }

                        allPeople[i].AddChildrenInfo(name, date);
                    }

                    if (!added)
                    {
                        allPeople.Add(new Person(name, date));
                    }
                }
            }
        }
    }
}
