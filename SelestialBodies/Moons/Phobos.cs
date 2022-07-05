using System.Security.Policy;

namespace CelestialBodies
{

    public sealed class Phobos : Moons
    {
        private Phobos()
        {
            Name = "Phobos";
            Picture = new Url("https://solarsystem.nasa.gov/moons/mars-moons/phobos/in-depth/");
            Distance = 9400;
            Mass = 10.6E15;
        }

        //For the Singleton
        private static readonly Lazy<Phobos> lazy = new Lazy<Phobos>(() => new Phobos());
        public static Phobos Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
