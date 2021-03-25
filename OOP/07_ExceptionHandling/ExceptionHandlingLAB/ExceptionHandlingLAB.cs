using System;

namespace ExceptionHandlingLAB
{
    class ExceptionHandlingLAB
    {
        static void Main(string[] args)
        {
            //  Exceptions in C# are objects
            //  The System.Exception class is a base for all
            //  exceptions in CLR
            //  Contains information for the cause of the error
            //  Message – a text description of the exception
            //  StackTrace – the snapshot of the stack at the
            //  moment of exception throwing
            //  InnerException – exception that caused the current exception(if any)

            // Types of Exceptions
            // NET exceptions inherit from System.Exception
            // The system exceptions inherit from System.SystemException
            // System.ArgumentException
            // System.FormatException
            // System.NullReferenceException
            // System.OutOfMemoryException
            // System.StackOverflowException
            // User - defined exceptions should inherit from System.Exception

            // How Do Exceptions Work? !!!
            // try - Run this code
            // catch - Execute this code when there is an exception
            // finally - Always run this code

            //Multiple Catch Blocks – Example
            string s = Console.ReadLine();
            try
            {
                int.Parse(s);
                Console.WriteLine(
                  "You entered a valid Int32 number {0}.", s);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine(
                  "The number is too big to fit in Int32!");
            }

            string str = Console.ReadLine();
            try
            {
                Int32.Parse(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot parse the number!");
            }
            // catch (FormatException) unreachable code
            // {
            //     Console.WriteLine("Invalid integer number!");
            // }
            // catch (OverflowException)
            // {
            //     Console.WriteLine(
            //          "The number is too big to fit in Int32!");
            // }

        }

        //try-finally – Example
        static void TestTryFinally()
        {
            Console.WriteLine("Code executed before try-finally.");
            try
            {
                string str = Console.ReadLine();
                int.Parse(str);
                Console.WriteLine("Parsing was successful.");
                return; // Exit from the current method
            }
            catch (FormatException)
            {
                Console.WriteLine("Parsing failed!");


            }
            finally
            {
                Console.WriteLine("This cleanup code is always executed.");
            }
            Console.WriteLine("This code is after the try-finally block.");
        }
    }
}
