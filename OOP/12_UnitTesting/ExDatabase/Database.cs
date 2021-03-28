using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExDatabase
{
    public class Database<T>
    {
        private T[] data;
        private const int capacity = 16;
        private int index;

        public Database()
        {
            data = new T[16];
            index = -1;
        }

        public Database(T[] values) : this()
        {

            if (values.Length > 16)
            {
                throw new InvalidOperationException("Parameter is too long!");
            }

            for (int i = 0; i < values.Length; i++)
            {
                this.data[i] = values[i];
            }

            index = values.Length - 1;
        }

        public void Add(T value)
        {
            var value1 = value as Person;
            var data1 = data as Person[];
            if (value1 != null && data1 != null)
            {
                var data2 = data1.Take(index + 1).ToArray();
                var name = data2.FirstOrDefault(x => x.Name == value1.Name);
                var id = data2.FirstOrDefault(x => x.Id == value1.Id);
                if (name != null || id != null)
                {
                    throw new InvalidOperationException("Object already exists!");
                }
            }

            if (index < capacity - 1)
            {
                data[++index] = value;
                return;
            }
            else
            {
                throw new InvalidOperationException("Database is Full!");
            }
        }

        public void Remove()
        {
            if (index == -1)
            {
                throw new InvalidOperationException("Database is Empty!");
            }
            else
            {
                index--;
            }
        }

        public Person FindByUsername(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Persons Name is Null!");
            }
            var data1 = data as Person[];
            var data2 = data1.Take(index + 1).ToArray();
            Person user = data2.FirstOrDefault(x => x.Name == name);
            if (user != null)
            {        
                return user;
            }
            else
            {
                throw new InvalidOperationException("Person does Not exist!");
            }
           
        }

        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Persons ID is less then 0!");
            }
            var data1 = data as Person[];
            var data2 = data1.Take(index + 1).ToArray();
            Person user = data2.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new InvalidOperationException("Person does Not exist!");
            }
        }

        public T[] Fetch()
        {
            return data.Take(16).ToArray();
        }
    }
}
