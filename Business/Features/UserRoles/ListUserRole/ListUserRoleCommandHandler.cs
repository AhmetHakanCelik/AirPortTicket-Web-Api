using Entities.Models;
using Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.UserRoles.ListUserRole
{
    internal sealed record ListUserRoleCommandHandler : IRequestHandler<ListUserRoleCommand,List<UserRole>>
    {
        private readonly IUserRoleRepository _repository;

        public ListUserRoleCommandHandler(IUserRoleRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<UserRole>> Handle(ListUserRoleCommand request, CancellationToken cancellationToken)
        {
            var response = await _repository.GetAll().ToListAsync(cancellationToken);
            return response;
        }
    }
}
