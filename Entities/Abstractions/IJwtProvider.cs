using Entities.Models;

namespace Entities.Abstractions
{
    public interface IJwtProvider
    {
        Task<string> CreateToken(AppUser user);
    }
}
