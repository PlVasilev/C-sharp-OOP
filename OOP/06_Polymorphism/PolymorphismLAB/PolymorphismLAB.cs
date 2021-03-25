using System;

namespace PolymorphismLAB
{
    class PolymorphismLAB
    {
        static void Main(string[] args)
        {

            // Variables are saved in a reference type
            // You can use only reference methods
            // If you need an object method you need to cast it or override it

            //   public class Person : Mammal, Animal { }
            // Animal person = new Person();
            // Mammal personOne = new Person();
            // Person personTwo = new Person();
            // Reference Type         Object Type

            //      Keyword - is
            //Check if an object is an instance of а specific class
            // public class Person : Mammal, Animal { }
            //  Animal person = new Person();
            //  Mammal personOne = new Person();
            //  Person personTwo = new Person();
            // if (person is Person) - Check object type of person
            // {
            // ((Person) person).getSalary(); - Cast to object type and use its methods
            // }
            // - Starting with C# 7.0, the is statement supports pattern matching. The is keyword supports the following patterns:
            //
            // - Type pattern, which tests whether an expression can be converted to a specified type and, if it can be, casts it to a variable of that type
            //   - Checks if object is of type person and casts it
            //   - if (personTwo is Person person) person.getSalary();
            //    public class Person : Mammal, Animal { }
            //    Mammal personOne = new Person();
            //    Person personTwo = new Person();
            //    if (personTwo is Person person)
            //    {
            //        person.getSalary();
            //    }
            //
            // - Constant pattern, which tests whether an expression evaluates to a specified constant value
            //   - When performing pattern matching with the constant pattern, is tests whether an expression equals a specified constant
            //     int i = 0;
            //     const max = 10;
            //     while (true)
            //     {
            //         Console.WriteLine($”i is { i}”);
            //         i++;
            //         if (i is max) break;
            //     }
            //
            // - var pattern, a match that always succeeds and binds the value of an expression to a new local variable
            //     A pattern match with the var pattern always succeeds
            //     If(expr is var varname)
            //     {
            //         // Do something with varname 
            //     }
            //     The value of expr is always assigned to a local variable named varname
            //     varname is a static variable of the same type as expr
            //     Note that if expr is null, the is expression still is true and assigns null to varname

            //      Keyword - as
            // You can use the as operator to perform certain types of conversions between compatible reference types
            //   When we Use As ... ITS A MUST TO CHECK IF IT IS NOT NULL
            //     public class Person : Mammal, Animal { }
            //     Animal person = new Person();
            //     Mammal personOne = new Person();
            //     Person personTwo;
            //     personTwo = personOne as Person;
            //     if (personTwo != null)
            //     {
            //      personTwo.Speack()
            //     }
            //      personTwo?.Speack() does the same thing as IF

            Console.WriteLine(MathOperation.Add(1, 4));
            Console.WriteLine(MathOperation.Add(1.4, 3.6));
            Console.WriteLine(MathOperation.Add(1.4m, 3.6m));
        }
    }
}
