using MediatR;

namespace TestN5.Application.Features.PermissionTypes.Queries.GetAllPermissions
{
    public class GetAllPermissionsQuery : IRequest<List<PermissionsVm>>
    {
    }
}
