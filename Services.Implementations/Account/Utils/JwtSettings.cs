namespace Services.Implementations.Account.Utils
{
    public class JwtSettings
    {
        public string ValidIssuer { get; set; }
        public string SecretKey { get; set; }
        public int RefreshTokenExpireTimeDays { get; set; }
        public int RefreshTokenTTLDays { get; set; }
        public int JwtExpireTimeMinutes { get; set; }
    }
}
