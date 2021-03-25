using System;

namespace ExceptionsLABEx
{
    class ExceptionsLABEx
    {
        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Shit happens");
            }
        }

        public static void DoWork()
        {
            try
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                Console.WriteLine(a + b);
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine("Please enter two numbers");
                // throw; // throws last exception up
                throw new ApplicationException("For your information", ie); // we throw new exeption up with the ie excep. as 2nd argument
                                                                            // 2nd is child exept with the message and stackTrace etc.                    
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Please enter only integers");
                throw fe; // rethrow fe exception - the same way
                throw; // rethrows last exception
            }
            finally
            {
                Console.WriteLine("Finnaly");
            }

        }

        public static void Worker()
        {
        }
    }
}
