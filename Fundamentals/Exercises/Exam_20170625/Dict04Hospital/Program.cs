using System;
using System.Collections.Generic;
using System.Linq;

namespace Dict04Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DepartmentCap = new Dictionary<string, int>();
            Dictionary<string, List<string>> DoctorPatients = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> DepartmentPatients = new Dictionary<string, List<string>>();

            string input = "";

            while ((input = Console.ReadLine()) != "Output")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string department = inputArr[0];
                string doctor = inputArr[1] + " " + inputArr[2];
                string patient = inputArr[3];

                if (!DepartmentCap.ContainsKey(department))
                {
                    DepartmentCap.Add(department, 0);
                }
                DepartmentCap[department]++;
                if (DepartmentCap[department] <= 60)
                {
                    if (!DoctorPatients.ContainsKey(doctor))
                    {
                        DoctorPatients.Add(doctor, new List<string>());
                    }
                    DoctorPatients[doctor].Add(patient);

                    if (!DepartmentPatients.ContainsKey(department))
                    {
                        DepartmentPatients.Add(department, new List<string>());
                    }
                    DepartmentPatients[department].Add(patient);
                }
                else
                {
                    DepartmentCap[department]--;
                }
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (inputArr.Length > 1 && int.TryParse(inputArr[1], out int roomNum))
                {
                    if (DepartmentPatients.ContainsKey(inputArr[0]))
                    {
                        SortedSet<string> names = new SortedSet<string>();
                        for (int i = 3 * (roomNum - 1); i < Math.Min((3 * (roomNum - 1)) + 3, 
                                                            DepartmentPatients[inputArr[0]].Count); i++)
                        {
                            names.Add(DepartmentPatients[inputArr[0]][i]);
                        }
                        Console.WriteLine(string.Join("\n", names));
                    }
                }
                else
                {
                    if (DepartmentPatients.ContainsKey(input))
                    {
                        Console.WriteLine(string.Join("\n", DepartmentPatients[input]));
                    }
                    else if (DoctorPatients.ContainsKey(input))
                    {
                        Console.WriteLine(string.Join("\n", DoctorPatients[input].OrderBy(x => x)));
                    }
                }

            }
        }
    }
}
