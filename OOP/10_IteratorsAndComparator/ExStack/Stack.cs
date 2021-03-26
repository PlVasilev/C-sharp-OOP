using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExStack
{
   public class Stack<T> : IEnumerable<T>
   {
       private IList<T> collection;

       public Stack()
       {
           collection = new List<T>();
       }

       public void Push(params T[] paramsToAdd)
       {
           for (int i = 0; i < paramsToAdd.Length; i++)
           {
               collection.Insert(0,paramsToAdd[i]);
           }
       }

       public void Pop()
       {
           if (collection.Count == 0)
           {
            throw new ArgumentException("No elements");
           }
           collection.RemoveAt(0);
       }

       public IEnumerator<T> GetEnumerator()
       {
           for (int i = 0; i < collection.Count; i++)
           {
               yield return collection[i];
           }
        }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
   }
}
