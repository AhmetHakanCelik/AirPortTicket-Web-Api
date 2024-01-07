
using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Auth.Register
{
    internal sealed class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var myuser = await _userRepository.GetByIdAsync(e => e.Email == request.Email);
            if(myuser is not null) 
            {
                throw new ArgumentException("Bu email zaten kullanımda");
            }

            AppUser newuser = new()
            {
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password
            };

            await _userRepository.AddAsync(newuser,cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
