using System;
using System.Collections.Generic;

namespace LABSetsAndDictionariesAdvanced
{
    class LABSetsAndDictionariesAdvanced
    {
        static void Main(string[] args)
        {
            //Dictionary < K, V > -collection of key and value pairs
            //Keys are unique
            //Keeps the keys in their order of addition
            //Uses a hash - table + list

            var fruitsSorted = new SortedDictionary<string, double>();
            fruitsSorted["kiwi"] = 4.50;

            var fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.20;

            var airplanes = new Dictionary<string, int>();
            airplanes.Add("Boeing 737", 130);
            airplanes.Remove("Boeing 737");

            var dictionary = new Dictionary<string, int>();
            dictionary.Add("Airbus A320", 150);
            if (dictionary.ContainsKey("Airbus A320"))
                Console.WriteLine($"Airbus A320 key exists");

            var dictionary1 = new Dictionary<string, int>();
            dictionary1.Add("Airbus A320", 150);
            Console.WriteLine(dictionary1.ContainsValue(150)); //true
            Console.WriteLine(dictionary1.ContainsValue(100)); //false

            //Multi-Dictionaries

            var grades = new Dictionary<string, List<int>>();
            grades["Peter"] = new List<int>();
            grades["Peter"].Add(5);
            grades["Kiril"] = new List<int>() { 6, 6, 3, 4, 6 };
            Console.WriteLine(string.Join(" ", grades["Kiril"]));

            //Sets - множества колекция от стойностти

            //A set keeps ONLY unique elements
            //Allows add / remove / search elements
            //Very fast performance
            //HashSet<T>
            //Keeps a set of elements in a hash-table
            //Elements are in no particular order
            //Similar to List<T>, but a different implementation

            HashSet<string> set = new HashSet<string>();
            set.Add("Pesho");
            set.Add("Pesho"); // Not added again
            set.Add("Gosho");
            Console.WriteLine(string.Join(", ", set)); // Pesho, Gosho
            Console.WriteLine(set.Contains("Georgi")); // false
            Console.WriteLine(set.Contains("Pesho")); // true
            set.Remove("Pesho");
            Console.WriteLine(set.Count); // 1

            //SortedSet<T>
            //The elements are ordered incrementally

            var set1 = new SortedSet<string>();
            set1.Add("Pesho");
            set1.Add("Pesho");
            set1.Add("Gosho");
            set1.Add("Maria");
            set1.Add("Alice");
            Console.WriteLine(string.Join(", ", set1));



        }
    }
}
