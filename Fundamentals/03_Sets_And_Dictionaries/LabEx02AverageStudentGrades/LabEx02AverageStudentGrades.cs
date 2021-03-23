using System;
using System.Collections.Generic;
using System.Linq;

namespace LabEx02AverageStudentGrades
{
    class LabEx02AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentGrade = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!studentGrades.ContainsKey(studentGrade[0]))
                {
                    studentGrades[studentGrade[0]] = new List<double>();
                }
                studentGrades[studentGrade[0]].Add(double.Parse(studentGrade[1]));
            }
            foreach (var student in studentGrades)
            {
                Console.WriteLine(
                    $"{student.Key} -> {string.Join(" ", student.Value.Select(i => i.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
