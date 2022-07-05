using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Mercury : TerrestrialPlanets
    {
        private Mercury()
        {
            Name = "Mercury";
            Picture = new Url("https://solarsystem.nasa.gov/planets/mercury/overview/");
            Distance = 29354000;
            Mass = 3.285E23;
            OrbitalPeriod = 88;
        }

        //For the Singleton
        private static readonly Lazy<Mercury> lazy = new Lazy<Mercury>(() => new Mercury());
        public static Mercury Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
