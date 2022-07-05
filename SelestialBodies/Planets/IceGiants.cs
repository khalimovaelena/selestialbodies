using System;

namespace CelestialBodies
{
    public class IceGiants : Planets, ICelestialBodyProperties
    {
        public bool CanBeTerraformed()
        {
            return true;
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
