﻿namespace Domain.Exceptions
{
    public enum ExceptionCode
    {
        ItemDoesntExist = 1,
        SuchUserAlreadyExists = 2,
        UserIsNotVerified = 3,
        IncorrectPassword = 4,
        InvalidRefreshToken = 5,
        UserDoesntExist = 6,
        VerificationFailed = 7,
        InvalidResetToken = 8,
    }
}
