using DataAccess.DbContext;
using Entities.Abstractions;
using Entities.Models;
using Entities.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DataAccess.Services
{
    internal sealed class JwtProvider : IJwtProvider
    {
        private readonly ApplicationDbContext _context;
        private readonly IOptions<Jwt> _jwt;

        public JwtProvider(ApplicationDbContext context, IOptions<Jwt> jwt)
        {
            _context = context;
            _jwt = jwt;
        }

        public async Task<string> CreateToken(AppUser user)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("NameLastName",user.Name+" "+user.LastName)
            };

            JwtSecurityToken securitytoken = new JwtSecurityToken(
                issuer: "",
                audience: _jwt.Value.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddDays(1),
                signingCredentials:
                new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Value.SecretKey)), SecurityAlgorithms.HmacSha512));


            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            string token = handler.WriteToken(securitytoken);

            return token;
        }
    }
}
