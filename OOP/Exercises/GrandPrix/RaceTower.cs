using System;
using System.Collections.Generic;
using System.Text;


public class RaceTower
{
    private int totalLaps = 0;
    private int trackLegth = 0;
    List<Driver> drivers;

    public RaceTower()
    {
        drivers = new List<Driver>();
    }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        totalLaps = lapsNumber;
        trackLegth = trackLength;
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        string type = commandArgs[0];
        string name = commandArgs[1];
        int hp = int.Parse(commandArgs[2]);
        double fuelAmount =double.Parse(commandArgs[3]);
        string tyreType = commandArgs[4];
        double tyreHardness = double.Parse(commandArgs[5]);
        double grip = 0;
        if (tyreType == "Ultrasoft")
        {
            grip = double.Parse(commandArgs[6]); 
        }
        try
        {
            Tyre tyre;
            if (tyreType == "Ultrasoft")
            {
                tyre = new UltrasoftTyre(tyreType, tyreHardness,grip);
            }
            else
            {
                tyre = new HardTyre(tyreType, tyreHardness);
            }
            Car car = new Car(hp, fuelAmount, tyre);
            if (type == "Aggressive")
            {
                Driver driver = new AggressiveDriver(name, car);
                drivers.Add(driver);
            }
            else if (type == "Endurance")
            {
                Driver driver = new EnduranceDriver(name, car);
                drivers.Add(driver);
            }
        }
        catch (Exception e )
        {
            Console.WriteLine(e.Message);
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        return null;
    }

    public string GetLeaderboard()
    {
        return null;
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

}

