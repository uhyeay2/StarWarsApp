namespace StarWarsApp.Domain.Models
{
    public class Person
    {
        public Person(int starWarsApiId, string name, string height, string mass, string hairColor, string eyeColor, string gender, string birthday, Planet? homeWorld)
        {
            StarWarsApiId = starWarsApiId;
            Name = name;
            Height = height;
            Mass = mass;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Gender = gender;
            Birthday = birthday;
            HomeWorld = homeWorld;
        }

        public int StarWarsApiId { get; set; }

        public string Name { get; set; }

        public string Height { get; set; }

        public string Mass { get; set; }

        public string HairColor { get; set; }

        public string EyeColor { get; set; }

        public string Gender { get; set; }

        public string Birthday { get; set; }

        public Planet? HomeWorld { get; set; }
    }
}
