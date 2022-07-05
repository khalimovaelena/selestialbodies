using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Saturn : GasGiants
    {
        private Saturn()
        {
            Name = "Saturn";
            Picture = new Url("https://solarsystem.nasa.gov/planets/saturn/overview/");
            Distance = 918297097;
            Mass = 5.683E26;
            OrbitalPeriod = 10759;
            SatelliteMoons.Add(Titan.Instance);
            //we can add other moons
        }

        //For the Singleton
        private static readonly Lazy<Saturn> lazy = new Lazy<Saturn>(() => new Saturn());
        public static Saturn Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
