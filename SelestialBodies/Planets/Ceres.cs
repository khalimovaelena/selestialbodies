using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Ceres : DwarfPlanets
    {
        private Ceres()
        {
            Name = "Ceres";
            Picture = new Url("https://solarsystem.nasa.gov/planets/dwarf-planets/ceres/overview/");
            Distance = 240731977;
            Mass = 9.39E20;
            OrbitalPeriod = 1680;
        }

        //For the Singleton
        private static readonly Lazy<Ceres> lazy = new Lazy<Ceres>(() => new Ceres());
        public static Ceres Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
