using AutoMapper;
using MediatR;

namespace TestN5.Application.Features.PermissionTypes.Queries.GetAllPermissions
{
    public class GetAllPermissionsQueryHandler : IRequestHandler<GetAllPermissionsQuery, List<PermissionsVm>>
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllPermissionsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<PermissionsVm>> Handle(GetAllPermissionsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
