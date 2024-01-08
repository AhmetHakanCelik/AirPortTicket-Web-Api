using Entities.Abstractions;
using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Auth.Login
{
    internal sealed class LoginCommandHandler : IRequestHandler<LoginCommand,LoginCommandRepsonse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public LoginCommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<LoginCommandRepsonse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _userRepository.GetByIdAsync(e => e.Email == request.Email);
            if(user is null)
            {
                throw new ArgumentException("Geçersiz e posta adresi");
            }

            var passwordcheck = await _userRepository.GetByIdAsync(e => e.Password == request.Password);
            if (passwordcheck is null)
            {
                throw new ArgumentException("Geçersiz Şifre");
            }

            string token = await _jwtProvider.CreateToken(user);

            return new(AccesToken: token, UserId: user.Id);
        }
    }
}
