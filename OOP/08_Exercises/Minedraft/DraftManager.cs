
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private string mode;
    private double energyStored;
    private double oreMined;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        providers = new List<Provider>();
        mode = "Full";

    }

    public string RegisterHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double enrgyRequerment = double.Parse(arguments[3]);

        if (type == "Hammer")
        {
            Harvester harvester = new HammerHarvester(id, oreOutput, enrgyRequerment);
            harvesters.Add(harvester);
        }
        else if (type == "Sonic")
        {
            Harvester harvester = new SonicHarvester(id, oreOutput, enrgyRequerment, int.Parse(arguments[4]));
            harvesters.Add(harvester);
        }

        return $"Successfully registered {type} Harvester - {id}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);
        if (type == "Solar")
        {
            Provider provider = new SolarProvider(id, energyOutput);
            providers.Add(provider);
        }
        else
        {
            Provider provider = new PressureProvider(id, energyOutput);
            providers.Add(provider);
        }
        return $"Successfully registered {type} Provider - {id}";
    }

    public string Day()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        double energyProvided = providers.Sum(x => x.EnergyOutput);
        double oreMinedForADay = harvesters.Sum(x => x.OreOutput);
        sb.AppendLine($"Energy Provided: {energyProvided}");
        energyStored += energyProvided;
        double energyNeeded = harvesters.Sum(x => x.EnergyRequirement);
        switch (mode)
        {
            case "Full":
                if (energyNeeded <= energyStored)
                {
                    energyStored -= energyNeeded;
                    oreMined += oreMinedForADay;
                    sb.AppendLine($"Plumbus Ore Mined: {oreMinedForADay}");

                }
                else
                {
                    sb.AppendLine($"Plumbus Ore Mined: 0");

                }
                break;
            case "Half":
                if (energyNeeded * 0.6 <= energyStored)
                {
                    energyStored -= energyNeeded;
                    oreMined += oreMinedForADay * 0.5;
                    sb.AppendLine($"Plumbus Ore Mined: {oreMinedForADay * 0.5}");
                }
                else
                {
                    sb.AppendLine($"Plumbus Ore Mined: 0");
                }
                break;
            case "Energy":
                sb.AppendLine($"Plumbus Ore Mined: 0");
                break;
            default:
                break;
        }

        return sb.ToString().TrimEnd();
    }

    public string Mode(List<string> arguments)
    {
        mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        if (providers.Any(x => x.Id == id) || harvesters.Any(x => x.Id == id))
        {
            Provider provider = providers.Where(x => x.Id == id).FirstOrDefault();
            Harvester harvester = harvesters.Where(x => x.Id == id).FirstOrDefault();
            if (provider != null)
            {
                if (provider.GetType().Name == "SolarProvider")
                {
                    return $"Solar Provider - {provider.Id}\nEnergy Output: {provider.EnergyOutput}";
                }
                else
                {
                    return $"Pressure Provider - {provider.Id}\nEnergy Output: {provider.EnergyOutput}";
                }

            }
            else
            {
                if (harvester.GetType().Name == "HammerHarvester")
                {
                    return $"Hammer Harvester - {harvester.Id}\nOre Output: {harvester.OreOutput}\nEnergy Requirement: {harvester.EnergyRequirement}";
                }
                else
                {
                    return $"Sonic Harvester - {harvester.Id}\nOre Output: {harvester.OreOutput}\nEnergy Requirement: {harvester.EnergyRequirement}";
                }
                
            }
        }
        else
        {
            throw new ArgumentException($"No element found with id - {id}");
        }
    }

    public string ShutDown()
    {
        return $"System Shutdown\nTotal Energy Stored: {energyStored}\nTotal Mined Plumbus Ore: {oreMined}";
    }
}

