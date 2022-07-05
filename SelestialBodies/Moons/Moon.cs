using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Moon : Moons
    {
        private Moon()
        {
            Name = "Moon";
            Picture = new Url("https://solarsystem.nasa.gov/moons/earths-moon/overview/");
            Distance = 239949;
            Mass = 7.35E22;
        }

        //For the Singleton
        private static readonly Lazy<Moon> lazy = new Lazy<Moon>(() => new Moon());
        public static Moon Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
