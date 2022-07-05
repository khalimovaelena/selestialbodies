using System;

namespace CelestialBodies
{
    public class Stars : SolarSystem, ICelestialBodyProperties
    {
        /// <summary>
        /// Planets which are moving around the Star 
        /// </summary>
        public ICollection<Planets> SatellitePlanets { get; set; } = new HashSet<Planets>();

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
            return SatellitePlanets.Count > 0;
        }
    }

}