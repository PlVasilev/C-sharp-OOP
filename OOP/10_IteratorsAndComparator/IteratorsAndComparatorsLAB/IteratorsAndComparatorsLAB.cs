using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace IteratorsAndComparatorsLAB
{
    class IteratorsAndComparatorsLAB
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student() {Name = "Pesho"});
            students.Add(new Student() {Name = "Gosho"});
            students.Add(new Student() {Name = "Kiro"});

            var studentEnumerator = students.GetEnumerator();

            while (studentEnumerator.MoveNext())
            {
                Console.WriteLine(studentEnumerator.Current.Name);
            }

            Console.WriteLine(studentEnumerator.MoveNext());

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.SUm(1, 2, 3, 4, 5));

            StudentCollection studentCollection = new StudentCollection(students);

            foreach (var student in studentCollection)
            {
                
            }
        }
    }
}
