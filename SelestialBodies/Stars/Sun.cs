using System;
using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Sun : Stars
    {
        private Sun()
        {
            Name = "Sun";
            Picture = new Url("https://solarsystem.nasa.gov/solar-system/sun/overview/");
            Distance = 0; //Sun distance from the Sun is 0
            Mass = 1.989E30;
            SatellitePlanets.Add(Mercury.Instance);
            SatellitePlanets.Add(Venus.Instance);
            SatellitePlanets.Add(Earth.Instance);
            SatellitePlanets.Add(Mars.Instance);
            SatellitePlanets.Add(Jupiter.Instance);
            SatellitePlanets.Add(Saturn.Instance);
            SatellitePlanets.Add(Uranus.Instance);
            SatellitePlanets.Add(Neptune.Instance);
            SatellitePlanets.Add(Ceres.Instance);
            SatellitePlanets.Add(Pluto.Instance);
        }

        //For the Singleton
        private static readonly Lazy<Sun> lazy = new Lazy<Sun>(() => new Sun());
        public static Sun Instance
        {
            get
            {
                return lazy.Value;
            }
        }  
    }
}
