using System;

namespace Ex03Mankind
{
    class Ex03Mankind
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studentArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] workerArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(studentArr[0],studentArr[1], studentArr[2]);
                Worker worker = new Worker(workerArr[0], workerArr[1], double.Parse(workerArr[2]), double.Parse(workerArr[3]));

                Console.WriteLine($"First Name: {student.FirstName}");
                Console.WriteLine($"Last Name: {student.LastName}");
                Console.WriteLine($"Faculty number: {student.FacultyNumber}");
                Console.WriteLine();
                Console.WriteLine($"First Name: {worker.FirstName}");
                Console.WriteLine($"Last Name: {worker.LastName}");
                Console.WriteLine($"Week Salary: {worker.WeekSalary:f2}");
                Console.WriteLine($"Hours per day: {worker.HowersPerDay:f2}");
                Console.WriteLine($"Salary per hour: {worker.WeekSalary / 5 / worker.HowersPerDay:f2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
