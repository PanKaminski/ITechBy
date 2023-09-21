namespace Services.Abstractions.Common.OperationResult
{
    public enum ServerMessageCode
    {
        None = 0,
        RegistrationSuccess = 1,
        EmailVerificationSuccess = 2,
        VerificationFailed = 3,
        InvalidUser = 4,
        CheckEmailForPswResetInstructions = 5,
        ResetPasswordSuccess = 9,
    }
}
