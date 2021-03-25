using System;
using System.Collections.Generic;
using System.Text;

namespace RandomList
{
    public class RandomList : List<string>
    {
        public Random randomGenerator { get; set; }

        public RandomList()
        {
            randomGenerator = new Random();
        }

        public string GetRandomElement()
        {
            if (Count < 1)
            {
                return "No questions available";
            }
            var index = randomGenerator.Next(0, Count - 1);
            string result = this[index];
            this.RemoveAt(index);
            return result;
        }
    }
}
