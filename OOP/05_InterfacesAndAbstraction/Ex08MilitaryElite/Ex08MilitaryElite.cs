using Ex08MilitaryElite.Classes;
using System;
using System.Collections.Generic;

namespace Ex08MilitaryElite
{
    public class Ex08MilitaryElite
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();
            List<Private> privates = new List<Private>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                string rank = input[0];
                string id = input[1];
                string firstName = input[2];
                string lastName = input[3];
                int counter = 0;

                switch (rank)
                {
                    case "Spy":
                        Soldier spy = new Spy(id, firstName, lastName, int.Parse(input[4]));
                        soldiers.Add(spy);
                        break;
                    case "Private":
                        Soldier privatee = new Private(id, firstName, lastName, decimal.Parse(input[4]));
                        soldiers.Add(privatee);

                        break;
                    case "LieutenantGeneral":
                        string[] ids = new string[input.Length - 5];
                        for (int i = 5; i < input.Length ; i++)
                        { 
                            ids[counter] = input[i];
                            counter++;
                        }
                        Soldier lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, decimal.Parse(input[4]), soldiers, ids);
                        soldiers.Add(lieutenantGeneral);
                        break;
                    case "Engineer":
                        if (input[5] == "Airforces" || input[5] == "Marines")
                        {
                            string[] arr = new string[input.Length - 6];
                            for (int i = 6; i < input.Length; i++)
                            {
                                arr[counter] = input[i];
                                counter++;
                            }
                            Soldier engineer = new Engineer(id, firstName, lastName, decimal.Parse(input[4]), input[5], arr);
                            soldiers.Add(engineer);
                        }                       
                        break;
                    case "Commando":
                        if (input[5] == "Airforces" || input[5] == "Marines")
                        {
                            string[] arr = new string[input.Length - 6];
                            for (int i = 6; i < input.Length; i++)
                            {
                                arr[counter] = input[i];
                                counter++;
                            }
                            Soldier comando = new Commando(id, firstName, lastName, decimal.Parse(input[4]), input[5], arr);
                            soldiers.Add(comando);
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            soldiers.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
