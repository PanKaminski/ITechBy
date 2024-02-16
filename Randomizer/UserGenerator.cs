using Bogus;
using Domain.Common.Enums;
using Infrastructure.Implementations.DataMaster;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Learning;

namespace Randomizer
{
    internal static class UserGenerator
    {
        public static void FillUsersInDataBase(ITechDbContext database)
        {
            var userRole = database.Roles.First(r => r.Type == RoleType.User);
            var countries = database.Countries.ToList();
            var languages = database.Languages.ToList();
            var levels = database.LanguageLevels.ToList();

            var users = GenerateUsers(userRole, countries, languages, levels);
            database.Users.AddRange(users);
            database.SaveChanges();
        }

        private static  IEnumerable<UserEntity> GenerateUsers(
            RoleEntity role, 
            List<CountryEntity> countries, 
            List<LanguageEntity> languages,
            List<LanguageLevelEntity> levels
            )
        {
            var id = 50;
            var rtFaker = GetRefreshToken();
            var langFaker = GetUserLanguages(languages, levels);
            var maxCountryId = countries.Count - 1;

            var userFaker = new Faker<UserEntity>()
                .RuleFor(u => u.Age, (f,u) => (byte)f.Random.Number(18,70))
                .RuleFor(u => u.CreatedTime, (f,u) => f.Date.Past())
                .RuleFor(u => u.Gender, f => f.PickRandom<GenderType>())
                .RuleFor(u => u.FirstName, (f,u) => f.Name.FirstName(u.Gender is GenderType.Man ? Bogus.DataSets.Name.Gender.Male : Bogus.DataSets.Name.Gender.Female))
                .RuleFor(u => u.LastName, (f,u) => f.Name.LastName(u.Gender is GenderType.Man ? Bogus.DataSets.Name.Gender.Male : Bogus.DataSets.Name.Gender.Female))
                .RuleFor(u => u.Email, (f,u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(u => u.PasswordHash, (f, u) => f.Random.Hash())
                .RuleFor(u => u.PasswordSalt, (f, u) => f.Random.Hash())
                .RuleFor(u => u.VerificationTime, (f, u) => f.Date.Past())
                .RuleFor(u => u.VerificationToken, (f, u) => null)
                .RuleFor(u => u.Status, (f, u) => AccountStatus.Approved)
                .RuleFor(u => u.RefreshToken, (f, u) => rtFaker.Generate())
                .RuleFor(u => u.Roles, (f, u) => new List<RoleEntity> { role })
                .RuleFor(u => u.Languages, (f,u) => langFaker.GenerateBetween(3,6))
                .RuleFor(u => u.Country, (f, u) => countries[f.Random.Int(0, maxCountryId)]);

            return userFaker.Generate(200);
        }

        private static Faker<RefreshTokenEntity> GetRefreshToken()
        {
            var id = 50;
            return new Faker<RefreshTokenEntity>()
            .RuleFor(rt => rt.CreatedTime, (f, rt) => f.Date.Past())
            .RuleFor(rt => rt.Source, (f, rt) => f.Random.Hash())
            .RuleFor(rt => rt.ExpireTime, (f, rt) => f.Date.Past());
        }

        private static Faker<UserLanguageEntity> GetUserLanguages(List<LanguageEntity> languages, List<LanguageLevelEntity> levels)
        {
            var id = 50;
            var maxLevel = levels.Count - 1;
            var maxLanguageIndex = languages.Count - 1;

            return new Faker<UserLanguageEntity>()
                .RuleFor(l => l.Level, (f, l) => levels[f.Random.Number(0, maxLevel)])
                .RuleFor(l => l.IsInLearning, (f, l) => f.Random.Bool())
                .RuleFor(l => l.Language, (f, l) => languages[f.Random.Number(0, maxLanguageIndex)]);
        }
    }
}
