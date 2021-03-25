using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06FootballTeam
{
    class Ex06FootballTeam
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Team":
                        try
                        {
                            Team team = new Team(input[1]);
                            teams.Add(team);
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                    case "Add":
                        if (teams.Any(x => x.Name == input[1]))
                        {
                            try
                            {
                                teams
                                    .Where(x => x.Name == input[1])
                                    .FirstOrDefault()
                                    .AddPlayer(new Player(input[2],
                                    int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7])));
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                        }
                        break;
                    case "Remove":
                        if (teams.Any(x => x.Name == input[1]))
                        {
                            try
                            {
                                teams
                                        .Where(x => x.Name == input[1])
                                        .FirstOrDefault()
                                        .RemovePlayer(input[2]);
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                        }
                        break;
                    case "Rating":                      
                            if (teams.Any(x => x.Name == input[1]))
                            {
                                string teamName = teams.Where(x => x.Name == input[1]).FirstOrDefault().Name;
                                double teamRaiting = teams.Where(x => x.Name == input[1]).FirstOrDefault().Rating();
                                Console.WriteLine($"{teamName} - {teamRaiting}");
                            }
                            else
                            {
                                Console.WriteLine($"Team {input[1]} does not exist.");
                            }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
