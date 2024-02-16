namespace Services.Abstractions.Common.Models
{
    public class UserSearchCard
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<string> NativeLanguages { get; set; }
        public List<string> LearningLanguages { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
    }
}
