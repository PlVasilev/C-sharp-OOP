using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsLAB
{
    public class StudentCollection : IEnumerable<Student>
    {
        private readonly List<Student> students;

        public StudentCollection(List<Student> students)
        {
            this.students = students;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Count; i++)
            {
                yield return this.students[i]; //  yield позволява да фориичваме // ТАКА ИМПЛЕМЕНТИРАМЕ IENUMERAOTR-a
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}

