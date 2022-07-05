using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Venus : TerrestrialPlanets
    {
        private Venus()
        {
            Name = "Venus";
            Picture = new Url("https://solarsystem.nasa.gov/planets/venus/overview/");
            Distance = 67301990;
            Mass = 4.867E24;
            OrbitalPeriod = 225;
        }

        //For the Singleton
        private static readonly Lazy<Venus> lazy = new Lazy<Venus>(() => new Venus());
        public static Venus Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
