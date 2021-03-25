using System;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, IncreasedOre(oreOutput), IncreasedEnergy(energyRequirement))
    {
    }

    private static double IncreasedEnergy(double energyRequirement) => energyRequirement * 2;

    private static double IncreasedOre(double oreOutput) => oreOutput * 3;

}

