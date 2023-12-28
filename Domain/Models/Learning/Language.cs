namespace Domain.Models.Learning
{
    public class Language
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }

        public ICollection<UserLanguage> UserLanguages { get; set; } = new List<UserLanguage>();
    }
}
