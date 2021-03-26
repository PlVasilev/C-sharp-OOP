using System;
using System.ComponentModel;

namespace ExListyIterator
{
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T>
    {
        private List<T> listy;

        public ListyIterator(params T[] paramsToAdd)
        {
            listy = new List<T>();
        }

        public int CurrentIndex { get; set; }

        public void Create(params T[] paramsToAdd)
        {
            listy = paramsToAdd.ToList();
        }

        public bool Move()
        {
            if (CurrentIndex + 1 > listy.Count - 1)
            {
                return false;
            }   
            CurrentIndex++;
            return true;
        }

        public bool HasNext()
        {
            if (CurrentIndex + 1 > listy.Count - 1 )
            {
                return false;
            }
            if (listy[CurrentIndex + 1] == null)
            {
                return false;
            }
            return true;
        }

        public void Print()
        {
            if (listy.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(listy[CurrentIndex]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", listy));
        }

        public void END()
        {
            Environment.Exit(0);
        }
    }

}
