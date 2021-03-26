using System.Collections.Generic;

namespace GenericsLab
{
    using System;

    public class Box<T> // <T> it means the class is generic
    {
        private IList<T> _items;
        private static T[] itemsT;

        public Box()
        {
            _items = new List<T>();
        }


        public void Add(T item)
        {
            _items.Insert(0,item);
        }

        public T Remove()
        {
            var item = _items[0];
            _items.RemoveAt(0);
            return item;
        }

        public int Count()
        {
            return _items.Count;
        }

        static T[] Create(int count, T item)
        {
            itemsT = new T[count];
            for (int i = 0; i < count; i++)
            {
                itemsT[i] = item;
            }

            return itemsT;
        }
     }
}
