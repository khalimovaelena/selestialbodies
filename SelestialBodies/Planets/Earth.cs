using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Earth : TerrestrialPlanets
    {
        private Earth()
        {
            Name = "Earth";
            Picture = new Url("https://solarsystem.nasa.gov/planets/earth/overview/");
            Distance = 94508233;
            Mass = 5.972E24;
            OrbitalPeriod = 365;
            SatelliteMoons.Add(Moon.Instance);
        }

        //For the Singleton
        private static readonly Lazy<Earth> lazy = new Lazy<Earth>(() => new Earth());
        public static Earth Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
