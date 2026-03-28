using System;

namespace Mods.ReEvaporation.Scripts
{
    public class EvaporationSettings
    {
        public bool EnableMod { get; set; } = true;

        public float CoveredEvaporationRate { get; set; } = 0.5f;

        public float UncoveredEvaporationRate { get; set; } = 1.0f;

        public int MaxSearchHeight { get; set; } = 15;

        public int UpdateInterval { get; set; } = 111;

        public float GetValidatedEvaporationRate()
        {
            return Math.Max(0f, Math.Min(4f, CoveredEvaporationRate));
        }

        public float GetValidatedUncoveredEvaporationRate()
        {
            return Math.Max(0f, Math.Min(4f, UncoveredEvaporationRate));
        }

        public int GetValidatedUpdateInterval()
        {
            return Math.Max(10, Math.Min(1200, UpdateInterval));
        }

        public int GetValidatedMaxHeight()
        {
            return Math.Max(3, Math.Min(25, MaxSearchHeight));
        }
    }
}
