
    public class SonicHarvester : Harvester
    {
        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, DecreaseEnergy(energyRequirement, sonicFactor))
        {    
        }
        private static double DecreaseEnergy (double energyRequirement, int sonicFactor) => energyRequirement / sonicFactor;
}

