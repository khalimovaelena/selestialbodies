using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Uranus : IceGiants
    {
        private Uranus()
        {
            Name = "Uranus";
            Picture = new Url("https://solarsystem.nasa.gov/planets/uranus/overview/");
            Distance = 1882270093;
            Mass = 8.681E25;
            OrbitalPeriod = 30687;
            //we can add all moons
        }

        //For the Singleton
        private static readonly Lazy<Uranus> lazy = new Lazy<Uranus>(() => new Uranus());
        public static Uranus Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }

}