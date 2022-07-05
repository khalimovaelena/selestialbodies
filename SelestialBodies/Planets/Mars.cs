using System.Security.Policy;

namespace CelestialBodies
{
    public class Mars : TerrestrialPlanets
    {
        private Mars()
        {
            Name = "Mars";
            Picture = new Url("https://solarsystem.nasa.gov/planets/mars/overview/");
            Distance = 128537254;
            Mass = 6.39E23;
            OrbitalPeriod = 687;
            SatelliteMoons.Add(Phobos.Instance);
            SatelliteMoons.Add(Deimos.Instance);
        }

        //For the Singleton
        private static readonly Lazy<Mars> lazy = new Lazy<Mars>(() => new Mars());
        public static Mars Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
