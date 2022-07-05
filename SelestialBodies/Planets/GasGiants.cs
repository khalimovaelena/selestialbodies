using System;

namespace CelestialBodies
{
    public class GasGiants : Planets, ICelestialBodyProperties
    {
        public bool CanBeTerraformed()
        {
            return false;
        }

        public bool CanSustainLife()
        {
            return false;
        }

        public bool HasSatellites()
        {
            return SatelliteMoons.Count > 0;
        }
    }
}
