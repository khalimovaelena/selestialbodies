using System.Security.Policy;

namespace CelestialBodies
{
    /// <summary>
    /// Abstract class to describe celestial Object
    /// </summary>
    public abstract class SolarSystem
    {
        /// <summary>
        /// Name of the object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL link to the picture and description of the object on the NASA website
        /// </summary>
        public Url Picture { get; set; }

        /// <summary>
        /// Distance from the Sun (for Moons - from the parent planet) in millions kms
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// Mass of the object (in kilograms)
        /// </summary>
        public double Mass { get; set; }
    }
}