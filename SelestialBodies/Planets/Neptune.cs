using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Neptune : IceGiants
    {
        private Neptune()
        {
            Name = "Neptune";
            Picture = new Url("https://solarsystem.nasa.gov/planets/neptune/overview/");
            Distance = 2780908856;
            Mass = 1.024E26;
            OrbitalPeriod = 60190;
            //we can add all moons
        }

        //For the Singleton
        private static readonly Lazy<Neptune> lazy = new Lazy<Neptune>(() => new Neptune());
        public static Neptune Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
