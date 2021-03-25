using System;

namespace InterfacesAndAbstractionLAB
{
    class InterfacesAndAbstractionLAB
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            //Interface

            //An interface contains only the signatures of methods, properties, events or indexers
            //An interface can inherit from one or more base interfaces
            //When a base type list contains a base class and interfaces, the base class must come first in the list
            //A class that implements an interface can explicitly implement members of that interface
            //An explicitly implemented member cannot be accessed through a class instance, but only through an instance of the interface

            //There are two ways to achieve abstraction
            //    Interfaces
            //    Abstract class

        }
        public interface IPrintable
        {
            void Print();
        }

        class Document : IPrintable
        {
            public void Print()
            { Console.WriteLine("Hello"); }
        }

        public interface IAnimal { }

        public abstract class Mammal { }

        public class Person : Mammal, IAnimal { }

    }
}
