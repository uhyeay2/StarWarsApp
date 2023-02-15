namespace StarWarsApp.Domain.Models
{
    public class Person
    {
        public Person(string? name, string? hairColor, string? eyeColor, string? gender, string? homeWorld, string? dateOfBirth)
        {
            Name = name ?? string.Empty;
            HairColor = hairColor ?? string.Empty;
            EyeColor = eyeColor ?? string.Empty;
            Gender = gender ?? string.Empty;
            HomeWorld = homeWorld ?? string.Empty;
            DateOfBirth = dateOfBirth ?? string.Empty;
        }

        public string Name { get; set; } = null!;

        public string HairColor { get; set; } = string.Empty;

        public string EyeColor { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string HomeWorld { get; set; } = string.Empty;

        public string DateOfBirth { get; set; } = string.Empty;
    }
}
