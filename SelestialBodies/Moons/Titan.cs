using System.Security.Policy;

namespace CelestialBodies
{
    public sealed class Titan : Moons
    {
        private Titan()
        {
            Name = "Titan";
            Picture = new Url("https://solarsystem.nasa.gov/moons/saturn-moons/titan/overview/");
            Distance = 845270551;
            Mass = 1.3452E23;
        }

        //For the Singleton
        private static readonly Lazy<Titan> lazy = new Lazy<Titan>(() => new Titan());
        public static Titan Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
