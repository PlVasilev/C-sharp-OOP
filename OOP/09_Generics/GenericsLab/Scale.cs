using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab
{
    public class Scale<T> where T : IComparable<T> // ограничаваме Т да имплементира Icomparable за да може да се сравни
    {
        public T Left { get; set; }
        public T Right { get; set; }

        public Scale(T left,T right)
        {
            Left = left;
            Right = right;
        }

        public T GetHavier()
        {
            if (Left.Equals(Right))
            {
              return  default(T);
            }

            if (Left.CompareTo(Right) > 0) // сравняване на Т в случея ако LEFT e по-голямо връща 1 ако LIGHT връща -1;
            {
                return Left;
            }
            else
            {
                return Right;
            }
        }
    }
}
