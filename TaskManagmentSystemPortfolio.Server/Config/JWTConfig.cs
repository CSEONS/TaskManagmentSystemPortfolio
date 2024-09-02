namespace TaskManagmentSystemPortfolio.Server.Config
{
    public class JWTConfig
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public static string SecretKey { get; set; }
        public static string Issuer { get; internal set; }
        public static string Audience { get; internal set; }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    }
}
