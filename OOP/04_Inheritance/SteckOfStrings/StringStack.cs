using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SteckOfStrings
{
    public class StringStack : List<string> // as base we take List<string>
    {
        public void Push(string element)
        {
            Add(element);
        }

        public string Pop()
        {
            string element = GetLastElement();
            RemoveAt(Count - 1);
            return element;
        }

        public string Peek()
        {
            return GetLastElement();
        }

        public bool IsEmpty()
        {
            return Count < 1;
        }

        private string GetLastElement()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return this.Last();
        }
    }
}
