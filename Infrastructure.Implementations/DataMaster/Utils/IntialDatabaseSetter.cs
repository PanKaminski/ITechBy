using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Learning;
using System.Text.Json;

namespace Infrastructure.Implementations.DataMaster.Utils
{
    internal static class IntialDatabaseSetter
    {
        public static CountryEntity[] GetCountries()
        {
            var path = Path.Combine(Environment.CurrentDirectory, @"Files\", "countries.json");
            var jsonText = File.ReadAllText(path);
            var countries = JsonSerializer.Deserialize<CountryEntity[]>(jsonText);

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i].Id = i + 1;
                countries[i].CreatedTime = DateTime.UtcNow;
            }

            return countries;
        }

        public static LanguageEntity[] GetLanguages()
        {
            var path = Path.Combine(Environment.CurrentDirectory, @"Files\", "languages.json");
            var jsonText = File.ReadAllText(path);
            var langDictionary = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonText);

            var languages = new List<LanguageEntity>();
            var id = 1;
            foreach (var entry in langDictionary)
            {
                languages.Add(new LanguageEntity
                {
                    Id = id++,
                    CreatedTime = DateTime.UtcNow,
                    Code = entry.Key,
                    Name = entry.Value.GetProperty("nameEnglish").GetString(),
                    NativeName = entry.Value.GetProperty("nameNative").GetString()
                });
            }

            return languages.ToArray();
        }
    }
}
