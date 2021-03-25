
    public class PressureProvider : Provider
    {
        public PressureProvider(string id, double energyOutput) : base(id, IncreaseEnergy(energyOutput))
        {
        }
        private static double IncreaseEnergy(double energyOutput) => energyOutput * 1.5;
}

