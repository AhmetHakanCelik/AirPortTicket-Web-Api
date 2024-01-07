using Entities.Repositories;
using MediatR;

namespace Business.Features.Auth.Login
{
    internal sealed class LoginCommandHandler : IRequestHandler<LoginCommand>
    {
        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var emailcheck = await _userRepository.GetByIdAsync(e => e.Email == request.Email);
            if(emailcheck is null)
            {
                throw new ArgumentException("Geçersiz e posta adresi");
            }

            var passwordcheck = await _userRepository.GetByIdAsync(e => e.Password == request.Password);
            if (passwordcheck is null)
            {
                throw new ArgumentException("Geçersiz Şifre");
            }

        }
    }
}
