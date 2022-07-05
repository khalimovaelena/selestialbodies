using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Pluto : DwarfPlanets
    {
        private Pluto()
        {
            Name = "Pluto";
            Picture = new Url("https://solarsystem.nasa.gov/planets/dwarf-planets/pluto/overview/");
            Distance = 3212352514;
            Mass = 1.303E22;
            OrbitalPeriod = 90530;
        }

        //For the Singleton
        private static readonly Lazy<Pluto> lazy = new Lazy<Pluto>(() => new Pluto());
        public static Pluto Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
