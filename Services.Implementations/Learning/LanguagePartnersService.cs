using Domain.Common;
using Services.Abstractions.Common.Models;
using Services.Abstractions.Data;
using Services.Abstractions.Data.Repositories.LoadOptions;
using Services.Abstractions.Learning;

namespace Services.Implementations.Learning
{
    public class LanguagePartnersService : ILanguagePartnersService
    {
        private readonly IUnitOfWork unitOfWork;
        private const int PageLimit = 30;

        public LanguagePartnersService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<RandomPagedModel<UserSearchCard>> FindPartners(string userIdString, ICollection<int> viewedPages)
        {
            if (!int.TryParse(userIdString, out int userId))
                throw new ArgumentException("Invalid user");

            var currentUserDto = unitOfWork.UsersRepository.FirstOrDefault(u => u.Id == userId, false, new List<AccountLoadOptions> { AccountLoadOptions.WithLanguages });
            var learningLanguages = currentUserDto.Languages.Where(l => l.IsInLearning).Select(l => l.Id).ToList();

            var paginatedUsers = await unitOfWork.UsersRepository.GetPaginatedByLanguagesAsync(userId, viewedPages, learningLanguages, PageLimit);

            return new RandomPagedModel<UserSearchCard>
            {
                AttendedPages = paginatedUsers.AttendedPages,
                CurrentPage = paginatedUsers.CurrentPage,
                TotalCount = paginatedUsers.TotalCount,
                PageSize = paginatedUsers.PageSize,
                Items = paginatedUsers.Items.Select(u => new UserSearchCard
                {
                    UserId = u.Id,
                    Name = $"{u.FirstName} {u.LastName}",
                    NativeLanguages = u.Languages.Where(l => !l.IsInLearning).Select(ul => ul.Language.Code).ToList(),
                    LearningLanguages = u.Languages.Where(l => l.IsInLearning).Select(ul => ul.Language.Code).ToList(),
                    Country = u.Country.Name,
                }),
            };
        }
    }
}
