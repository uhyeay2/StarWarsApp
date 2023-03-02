namespace StarWarsApp.Domain.Models
{
    public class Planet
    {
        public Planet(int starWarsApiId, string name, string rotationPeriod, string orbitalPeriod, string climate, string gravity, string terrain, string surfaceWater, string population)
        {
            StarWarsApiId = starWarsApiId;
            Name = name;
            RotationPeriod = rotationPeriod;
            OrbitalPeriod = orbitalPeriod;
            Climate = climate;
            Gravity = gravity;
            Terrain = terrain;
            SurfaceWater = surfaceWater;
            Population = population;
        }

        public int StarWarsApiId { get; set; }

        public string Name { get; set; }

        public string RotationPeriod { get; set; }

        public string OrbitalPeriod { get; set; }

        public string Climate { get; set; }

        public string Gravity { get; set; }

        public string Terrain { get; set; }

        public string SurfaceWater { get; set; }

        public string Population { get; set; }
    }
}
