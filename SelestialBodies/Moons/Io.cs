using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Io : Moons
    {
        private Io()
        {
            Name = "Io";
            Picture = new Url("https://solarsystem.nasa.gov/moons/jupiter-moons/io/overview/");
            Distance = 261318;
            Mass = 8.9319E22;
        }

        //For the Singleton
        private static readonly Lazy<Io> lazy = new Lazy<Io>(() => new Io());
        public static Io Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
