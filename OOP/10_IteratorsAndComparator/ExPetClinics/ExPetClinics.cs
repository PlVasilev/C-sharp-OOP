using System;
using System.Linq;

namespace ExPetClinics
{
   public class ExPetClinics
    {
        static void Main(string[] args)
        {
            CommandInterpreterer commandInterpreterer = new CommandInterpreterer();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] arguments = Console.ReadLine().Split();

                try
                {
                    switch (arguments[0])
                    {
                        case "Create":
                            if (arguments[1] == "Pet")
                            {
                                commandInterpreterer.CreatePet(arguments[2],int.Parse(arguments[3]),arguments[4]);
                            }
                            else if (arguments[1] == "Clinic")
                            {
                                commandInterpreterer.CreateClinic(arguments[2], int.Parse(arguments[3]));
                            }
                            break;
                        case "Add":
                            Console.WriteLine(commandInterpreterer.Add(arguments[1], arguments[2]));                            
                            break;
                        case "Release":
                            Console.WriteLine(commandInterpreterer.Release(arguments[1]));
                            break;
                        case "HasEmptyRooms":
                            Console.WriteLine(commandInterpreterer.HasEmptyRooms(arguments[1]));
                            break;
                        case "Print":
                            if (arguments.Length == 2 )
                            {
                                commandInterpreterer.Print(arguments[1]);
                            }
                            else if (arguments.Length == 3)
                            {
                                commandInterpreterer.Print(arguments[1], int.Parse(arguments[2]));
                            }
                            break;
                    } 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
