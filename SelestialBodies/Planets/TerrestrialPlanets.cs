using System;

namespace CelestialBodies
{
    public class TerrestrialPlanets : Planets, ICelestialBodyProperties
    {
        public bool CanBeTerraformed()
        {
            return true;
        }

        public bool CanSustainLife()
        {
            return true;
        }

        public bool HasSatellites()
        {
            return SatelliteMoons.Count > 0;
        }
    }
}
