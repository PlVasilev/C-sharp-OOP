using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ExCustomList.Contracts;

namespace ExCustomList
{
    public class CustomList<T> : IEnumerable<T>, ICustomList<T> where T : IComparable<T>
    {
        private IList<T> customList;
        private IEnumerable<T> _enumerableImplementation;

        public CustomList()
        {
            customList = new List<T>();
        }

        public IList<T> List
        {
            get => customList;
            private set => customList = value;
        }

        public void Add(T element)
        {
            List.Add(element);
        }

        public T Remove(int index)
        {
            T elementToRemove = List[index];
            List.RemoveAt(index);
            return elementToRemove;
        }

        public bool Contains(T element)
        {
            return List.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T firstElement = List[index1];
            List[index1] = List[index2];
            List[index2] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            return List.Count(x => x.CompareTo(element) > 0);
        }

        public T Max()
        {
            T max = List[0];

            for (int i = 0; i < List.Count - 1; i++)
            {
                if (List[i].CompareTo(List[i + 1]) < 0)
                {
                    max = List[i + 1];
                }
            }
            return max;
        }

        public T Min()
        {

            T min = List[0];

            for (int i = 0; i < List.Count - 1; i++)
            {
                if (List[i].CompareTo(List[i + 1]) > 0)
                {
                    min = List[i + 1];
                }
            }
            return min;
        }

        public string Print()
        {
            List.GetEnumerator();
            StringBuilder sb = new StringBuilder();
            foreach (var item in List)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public void Sort()
        {
           List = List.OrderBy(x => x).ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _enumerableImplementation.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _enumerableImplementation).GetEnumerator();
        }
    }
}
