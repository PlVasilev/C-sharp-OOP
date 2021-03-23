using System;
using System.Collections.Generic;
using System.Linq;

namespace Wx11PartyResFilterModule
{
    class Ex11PartyResFilterModule
    {
        static void Main(string[] args)
        {
            HashSet<string> comingGuest = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToHashSet();
            HashSet<string> notComingGuests = new HashSet<string>();
            string[] comand = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            while (comand[0] != "Print")
            {
                string action = comand[0];
                string filterType = comand[1];
                string filterParameter = comand[2];

                if (action == "Add filter")
                {
                   comingGuest = AddFilter(comingGuest, filterType, filterParameter);
                   HashSet<string> removedGuests = AddFilterNotComing(comingGuest, filterType, filterParameter);
                    foreach (var item in removedGuests)
                    {
                        notComingGuests.Add(item);
                    }
                }
                else
                {
                    HashSet<string> addedGuests = AddFilterNotComing(notComingGuests, filterType, filterParameter);
                    foreach (var item in addedGuests)
                    {
                        comingGuest.Add(item);
                    }
                    notComingGuests = AddFilter(notComingGuests, filterType, filterParameter);
                   
                }
                comand = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            }
            print(comingGuest);
        }

        private static HashSet<string> AddFilterNotComing(HashSet<string> notComingGuests, string filterType, string filterParameter)
        {
            switch (filterType)
            {
                case "Starts with":
                    notComingGuests.Where(x => x.StartsWith(filterParameter)).ToHashSet();
                    break;
                case "Ends with":
                    notComingGuests.Where(x => x.EndsWith(filterParameter)).ToHashSet();
                    break;
                case "Lengt":
                    notComingGuests.Where(x => x.Length == int.Parse(filterParameter)).ToHashSet();
                    break;
                case "Contains":
                    notComingGuests.Where(x => x.Contains(filterParameter)).ToHashSet();
                    break;
                default:
                    break;
            }
            return notComingGuests;
        }

        private static void print(HashSet<string> comingGuest)
        {
            Console.WriteLine(string.Join(" ",comingGuest));
        }

        private static HashSet<string> AddFilter(HashSet<string> comingGuest, string filterType, string filterParameter)
        {
            switch (filterType)
            {
                case "Starts with":
                    comingGuest = comingGuest.Where(x => !x.StartsWith(filterParameter)).ToHashSet();
                    break;
                case "Ends with":
                    comingGuest = comingGuest.Where(x => !x.EndsWith(filterParameter)).ToHashSet();
                    break;
                case "Lengt":
                    comingGuest = comingGuest.Where(x => x.Length != int.Parse(filterParameter)).ToHashSet();
                    break;
                case "Contains":
                    comingGuest = comingGuest.Where(x => !x.Contains(filterParameter)).ToHashSet();
                    break;
                default:
                    break;
            }

            return comingGuest;
        }
    }
}
