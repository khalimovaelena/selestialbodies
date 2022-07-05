using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Ganymede : Moons
    {
        private Ganymede()
        {
            Name = "Ganymede";
            Picture = new Url("https://solarsystem.nasa.gov/moons/jupiter-moons/ganymede/overview/");
            Distance = 665085;
            Mass = 1.4819E23;
        }

        //For the Singleton
        private static readonly Lazy<Ganymede> lazy = new Lazy<Ganymede>(() => new Ganymede());
        public static Ganymede Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
