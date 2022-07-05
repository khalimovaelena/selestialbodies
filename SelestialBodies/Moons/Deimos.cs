using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Deimos : Moons
    {
        private Deimos()
        {
            Name = "Deimos";
            Picture = new Url("https://solarsystem.nasa.gov/moons/mars-moons/deimos/in-depth/");
            Distance = 23000;
            Mass = 2.4E15;
        }

        //For the Singleton
        private static readonly Lazy<Deimos> lazy = new Lazy<Deimos>(() => new Deimos());
        public static Deimos Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
