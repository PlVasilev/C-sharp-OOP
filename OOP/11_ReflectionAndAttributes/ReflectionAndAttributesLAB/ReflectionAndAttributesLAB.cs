using System;


  public  class ReflectionAndAttributesLAB
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            var result = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(result);
        }
    }

