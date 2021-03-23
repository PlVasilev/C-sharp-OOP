using System;
using System.Linq;
using System.Linq.Expressions;

namespace LABFunctonalProgramming
{
    class LABFunctonalProgramming
    {
        static void Main(string[] args)
        {
            // Implicit lambda expression
            //     msg => Console.WriteLine(msg);
            // Explicit lambda expression
            //     (String msg) => { Console.WriteLine(msg); }
            // Zero parameters
            //     () => { Console.WriteLine("hi"); }
            // More parameters
            //     (int x, int y) => { return x + y; }

            Console.WriteLine(string.Join(", "
            , Console.ReadLine()
            .Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % 2 == 0) // predicate
            .OrderBy(x => x)));

            //Delegates
            //A delegate is a type that represents references to methods with a particular parameter list and return type
            //Delegates are used to pass methods as arguments to other methods
            //Delegates can be used to define callback methods
            //public delegate int Multiplier(int x, int y);
            //Multiplier calc = (x, y) => x * y;

            //Generic Delegates -Func<T, V>
            //    Func<int, string> func = n => n.ToString();
            //Input and output type can be different type
            //Input and output type must be from type which we declare them
            //Func generic delegate use type parameters to define the number and types of input parameters,
            //and the return type of the delegate

            Func<int, string> func = n => n.ToString();
            // returns a result which is the last in <> (in this case string>), others are input;

            //Generic Delegates -Action < T >
            //    In.NET Action<T> is a void method:
            Action<string> print = message => Console.WriteLine(message);
            print("pesho");        //pesho
            print(5.ToString()); //5

            //Expression Trees
            //Expression trees represent code in a tree-like data structure,
            //    where each node is an expression, for example,
            //    a method call or a binary operation such as x<y
            //The C# compiler can generate expression 
            //    trees only from expression lambdas
            Expression<Func<int, bool>> lambda = num => num < 5; 
            // използава се за теглене на данни от базата, тук пишем филтри по какви критерии да се теглят и ...
            // ... се изпълнява когато се форийчне или се превърне в лист или арей
            
            //! predicate = функция която отчаква булев резултат (true or False)

        }
    }
}
