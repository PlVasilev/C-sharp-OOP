using System;
using System.Linq;

namespace LAB03CountUpWords
{
    class LAB03CountUpWords
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(X => char.IsUpper(X[0]))
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(X => char.IsUpper(X[0])) // тук се създава експрешън дърво
                .Select(w =>
               {
                   Console.WriteLine(w);
                   return w;

               }).Count(); // експрешън дърво е и се принтира когато се евалюетна (слага се метод като tolist toArr или др)

                
        }
    }
}
