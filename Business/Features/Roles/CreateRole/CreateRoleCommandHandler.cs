using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Roles.CreateRole
{
    internal sealed class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateRoleCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var RoleExist = await _roleRepository.GetByIdAsync(e => e.Name == request.Name);

            if (RoleExist != null)
            {
                throw new ArgumentException("bu rol zaten var");
            }

            AppRole role = new()
            {
                Name = request.Name
            };

            await _roleRepository.AddAsync(role, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
