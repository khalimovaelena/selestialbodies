using System;

namespace CelestialBodies
{
    public class Planets : SolarSystem
    {
        /// <summary>
        /// Orbital Period around the Sun (in Earth days)
        /// </summary>
        public double OrbitalPeriod { get; set; }

        /// <summary>
        /// Moons of the planet
        /// </summary>
        public ICollection<Moons> SatelliteMoons { get; set; } = new HashSet<Moons>();
    }
}
