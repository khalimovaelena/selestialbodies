using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Jupiter : GasGiants
    {
        private Jupiter()
        {
            Name = "Jupiter";
            Picture = new Url("https://solarsystem.nasa.gov/planets/jupiter/overview/");
            Distance = 461286121;
            Mass = 1.898E27;
            OrbitalPeriod = 4333;
            SatelliteMoons.Add(Io.Instance);
            SatelliteMoons.Add(Europa.Instance);
            SatelliteMoons.Add(Ganymede.Instance);
            //we can add other moons
        }

        //For the Singleton
        private static readonly Lazy<Jupiter> lazy = new Lazy<Jupiter>(() => new Jupiter());
        public static Jupiter Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
