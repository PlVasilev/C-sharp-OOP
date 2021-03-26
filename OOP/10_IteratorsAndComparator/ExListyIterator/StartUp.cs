using System.Linq;

namespace ExListyIterator
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listy = new ListyIterator<string>();

            string[] input = Console.ReadLine().Split();
            string[] paramsOfList = input.Skip(1).ToArray();

            while (true)
            {
                try
                {
                    switch (input[0])
                    {
                        case "Create":
                            listy.Create(paramsOfList);
                            break;
                        case "Move":
                            Console.WriteLine(listy.Move()); 
                            break;
                        case "Print":
                            listy.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(listy.HasNext());
                            break;
                        case "END":
                            listy.END();
                            break;
                        case "PrintAll":
                            listy.PrintAll();
                            break;
                            
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
