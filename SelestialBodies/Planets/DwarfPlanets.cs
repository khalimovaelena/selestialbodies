using System;

namespace CelestialBodies
{
    public class DwarfPlanets : Planets, ICelestialBodyProperties
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
            return false;
        }
    }
}
