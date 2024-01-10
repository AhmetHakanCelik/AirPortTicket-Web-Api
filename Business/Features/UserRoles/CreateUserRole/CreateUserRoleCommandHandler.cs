using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.UserRoles.CreateUserRole
{
    internal sealed class CreateUserRoleCommandHandler : IRequestHandler<CreateUserRoleCommand>
    {
        private readonly IUserRoleRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserRoleCommandHandler(IUserRoleRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var UserRoleSet = await _repository.GetByIdAsync(e => e.UserId == request.UserId && e.RoleId == e.UserId);

            if (UserRoleSet != null)
            {
                throw new ArgumentException("Kullanıcı bu role zaten sahip ");
            }

            UserRole userrole = new()
            {
                UserId = request.UserId,
                RoleId = request.RoleId,
            };

            await _repository.AddAsync(userrole,cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
