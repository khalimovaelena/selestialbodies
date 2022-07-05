namespace CelestialBodies
{
    /// <summary>
    /// Main Calculations for the task
    /// </summary>
    public class Calculations
    {
        private ICollection<SolarSystem> _celestialBodies;

        /// <summary>
        /// Create a collection for all celestial bodies
        /// </summary>
        public Calculations()
        {
            _celestialBodies = new HashSet<SolarSystem>();
            _celestialBodies.Add(Sun.Instance);
            _celestialBodies.Add(Mercury.Instance);
            _celestialBodies.Add(Venus.Instance);
            _celestialBodies.Add(Earth.Instance);
            _celestialBodies.Add(Mars.Instance);
            _celestialBodies.Add(Jupiter.Instance);
            _celestialBodies.Add(Saturn.Instance);
            _celestialBodies.Add(Uranus.Instance);
            _celestialBodies.Add(Neptune.Instance);
            _celestialBodies.Add(Ceres.Instance);
            _celestialBodies.Add(Pluto.Instance);
            _celestialBodies.Add(Moon.Instance);
            _celestialBodies.Add(Io.Instance);
            _celestialBodies.Add(Europa.Instance);
            _celestialBodies.Add(Ganymede.Instance);
            _celestialBodies.Add(Phobos.Instance);
            _celestialBodies.Add(Deimos.Instance);
            _celestialBodies.Add(Titan.Instance);
        }

        /// <summary>
        /// We can retrieve its name, a picture,
        /// distance from the sun, orbital period, and mass.
        /// </summary>
        public void PrintBodies()
        {
            foreach(var body in _celestialBodies)
            {
                if (body is Planets)
                {
                    var planet = (Planets)body;
                    Console.WriteLine($"Planet {planet.Name}, Picture:{planet.Picture}, Distance (from the Sun): {planet.Distance}, Orbital period (in Earth days): {planet.OrbitalPeriod}, Mass: {planet.Mass}");
                }
                else if (body is Stars)
                {
                    var star = (Stars)body;
                    Console.WriteLine($"Star {star.Name}, Picture:{star.Picture}, Distance (from the Sun): {star.Distance}, Mass: {star.Mass}");
                }
                else if (body is Moons)
                {
                    var moon = (Moons)body;
                    Console.WriteLine($"Moon {moon.Name}, Picture:{moon.Picture}, Distance (from the parent): {moon.Distance}, Mass: {moon.Mass}");
                }
            }
        }

        /// <summary>
        /// Use Lambda Expressions to select all celestial bodies sorted by orbital period around the sun 
        /// (in days) from shortest to the longest.
        /// </summary>
        /// <returns>Collection of the Planets</returns>
        public ICollection<Planets> GetOrderedPlanets()
        {
            return _celestialBodies
                .Where(body => body is Planets)
                .Cast<Planets>()
                .OrderBy(planet => planet.OrbitalPeriod)
                .ToList();
        }
    }
}
