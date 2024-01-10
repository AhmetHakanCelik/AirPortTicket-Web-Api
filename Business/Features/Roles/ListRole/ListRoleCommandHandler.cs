using Entities.Models;
using Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.Roles.GetRole
{
    internal sealed class ListRoleCommandHandler : IRequestHandler<ListRoleCommand, List<AppRole>>
    {
        private readonly IRoleRepository _roleRepository;

        public ListRoleCommandHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<List<AppRole>> Handle(ListRoleCommand request, CancellationToken cancellationToken)
        {
            var response = await _roleRepository.GetAll().ToListAsync(cancellationToken);
            return response;
        }
    }
}
