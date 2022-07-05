using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Europa : Moons
    {
        private Europa()
        {
            Name = "Europa";
            Picture = new Url("https://solarsystem.nasa.gov/moons/jupiter-moons/europa/overview/");
            Distance = 413265;
            Mass = 4.8017E22;
        }

        //For the Singleton
        private static readonly Lazy<Europa> lazy = new Lazy<Europa>(() => new Europa());
        public static Europa Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
