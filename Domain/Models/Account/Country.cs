namespace Domain.Models.Account
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
