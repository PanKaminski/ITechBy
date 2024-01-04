using Domain.Common.Enums;

namespace Services.Abstractions.RequestModels.Account
{
    public record RegisterRequestModel(string firstName, string lastName, string email,
         string password, GenderType gender, string countryCode, ICollection<string> languageCodes, 
         ICollection<string> targetLanguageCodes, string origin = null);
}
