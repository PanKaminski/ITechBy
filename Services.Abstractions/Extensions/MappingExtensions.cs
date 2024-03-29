﻿using Domain.Common.Enums;
using Domain.Models.Account;
using Domain.Models.Learning;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Learning;

namespace Services.Abstractions.Extensions
{
    public static class MappingExtensions
    {
        public static RefreshTokenEntity ToEntity(this RefreshToken refreshToken) => new RefreshTokenEntity
        {
            Id = refreshToken.Id,
            Source = refreshToken.Source,
            ExpireTime = refreshToken.ExpireTime,
            CreatedTime = refreshToken.CreatedTime,
        };

        public static RefreshToken ToModel(this RefreshTokenEntity refreshToken) =>
            new RefreshToken(refreshToken.Id, refreshToken.Source, refreshToken.ExpireTime, refreshToken.CreatedTime);

        public static UserEntity ToEntity(this User user) => new UserEntity
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Gender = user.Gender,
            RefreshToken = user.RefreshToken?.ToEntity(),
            PasswordHash = user.PasswordHash,
            PasswordSalt = user.PasswordSalt,
            PasswordResetTime = user.PasswordResetTime,
            VerificationTime = user.VerificationTime,
            Status = user.Status,
            VerificationToken = user.VerificationToken,
            ResetToken = user.ResetToken,
            ResetTokenExpires = user.ResetTokenExpires,
            Roles = user.Roles?.Select(r => r.ToEntity()).ToList(),
        };

        public static User ToModel(this UserEntity user) => new User
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Gender = user.Gender,
            RefreshToken = user.RefreshToken?.ToModel(),
            PasswordHash = user.PasswordHash,
            PasswordSalt = user.PasswordSalt,
            PasswordResetTime = user.PasswordResetTime,
            VerificationTime = user.VerificationTime,
            Status = user.Status,
            VerificationToken = user.VerificationToken,
            ResetToken = user.ResetToken,
            ResetTokenExpires = user.ResetTokenExpires,
            Roles = user.Roles?.Select(r => r.Type).ToList(),
        };

        public static RoleEntity ToEntity(this RoleType role) => new RoleEntity(role);

        public static Language ToModel(this LanguageEntity language) => new Language
        {
            Code = language.Code,
            Name = language.Name,
            NativeName = language.NativeName,
            UserLanguages = language.UserLanguages.Select(ul => ul.ToModel()).ToList(),
        };

        public static UserLanguage ToModel(this UserLanguageEntity userLanguage) => new UserLanguage
        {
            Id = userLanguage.Id,
            User = userLanguage.User?.ToModel(),
            Language = userLanguage.Language?.ToModel(),
            Level = userLanguage.Level?.Level ?? LanguageLevel.None,
            IsInLearning = userLanguage.IsInLearning,
        };

        public static Country ToModel(this CountryEntity country) => new Country 
        {
            Code = country.Code,
            Name = country.Name,
            Users = country.Users.Select(u => u.ToModel()).ToList(),
        };
    }
}