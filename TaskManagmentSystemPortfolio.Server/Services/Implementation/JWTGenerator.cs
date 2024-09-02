using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskManagmentSystemPortfolio.Server.Config;
using TaskManagmentSystemPortfolio.Server.Domain.Models;
using TaskManagmentSystemPortfolio.Server.Services.Abstract.JWT;

namespace TaskManagmentSystemPortfolio.Server.Services.Implementation
{
    public class JWTGenerator : IJWTGenerator
    {
        public string Generate(User user)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(JWTConfig.SecretKey);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                    Issuer = JWTConfig.Issuer,
                    Audience = JWTConfig.Audience
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception exception)
            {
                throw new Exception("Ошибка генерации токена", exception);
            }
        }


    }
}
