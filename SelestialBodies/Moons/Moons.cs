namespace CelestialBodies
{
    public class Moons : SolarSystem, ICelestialBodyProperties
    {
        public bool CanBeTerraformed()
        {
            return true;
        }

        public bool CanSustainLife()
        {
            return true;
        }

        public bool HasSatellites()
        {
            return false;
        }
    }
}
