using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Engine
{
    private RaceTower raceTower;

    public Engine()
    {
        this.raceTower = new RaceTower();
    }
    public void Run()
    {
        int lapsNumber = int.Parse(Console.ReadLine());
        int trackLength = int.Parse(Console.ReadLine());
        raceTower.SetTrackInfo(lapsNumber, trackLength);

        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string command = input[0];
        List<string> agrs = input.Skip(1).ToList();

        while (true)
        {
            switch (command)
            {
                case "RegisterDriver":
                    raceTower.RegisterDriver(agrs);
                    break;
                default:
                    break;
            }
        }
    }
}
