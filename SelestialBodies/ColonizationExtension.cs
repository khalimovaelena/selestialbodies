using System;

namespace CelestialBodies
{
    /// <summary>
    /// Extension method Colonize 
    /// </summary>
    public static class ColonizationExtension
    {
        /// <summary>
        /// an extension method named Colonize().
        /// </summary>
        /// <returns>TRUE if celestial body can be colonized</returns>
        public static bool Colonize(this ICelestialBodyProperties celestialBody)
        {
            return celestialBody.CanSustainLife() && celestialBody.CanBeTerraformed();
        }
    }
}
