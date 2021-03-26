using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExGenericBox
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public List<T> Items => items;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(int first, int second)
        {
            T firstElement = Items[first];
            Items[first] = Items[second];
            Items[second] = firstElement;
        }

        public int GetCount(T match)
        {
            int counter = 0;
            foreach (var item in Items)
            {
                if (item.CompareTo(match) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}