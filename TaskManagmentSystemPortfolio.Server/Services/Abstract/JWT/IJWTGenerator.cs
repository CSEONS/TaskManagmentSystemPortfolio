using TaskManagmentSystemPortfolio.Server.Domain.Models;

namespace TaskManagmentSystemPortfolio.Server.Services.Abstract.JWT
{
    public interface IJWTGenerator
    {
        string Generate(User user);
    }
}
