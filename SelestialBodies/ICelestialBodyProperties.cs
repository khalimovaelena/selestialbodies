namespace CelestialBodies
{
    /// <summary>
    /// Implement an interface for all celestial bodies
    /// </summary>
    public interface ICelestialBodyProperties
    {
        bool CanSustainLife();
        bool CanBeTerraformed();
        bool HasSatellites();
    }
}
