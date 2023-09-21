using Domain.Common.Enums;

namespace Services.Abstractions.RequestModels.Account
{
    public record RegisterRequestModel(string firstName, string lastName, string email,
         string password, GenderType gender, string origin = null);
}
