using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Facade.Network.ComponentType;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.ComponentType;

public class ConnectionComponentTypeController(IConnectionComponentTypeRepo repo) : BaseController<ConnectionComponentType, ConnectionComponentTypeViewModel>(repo) {
    protected override ConnectionComponentType ToModel(ConnectionComponentTypeViewModel viewmodel) =>
        new ConnectionComponentType(PropertyCopier.CopyPropertiesFrom<ConnectionComponentTypeViewModel, ConnectionComponentTypeData>(viewmodel));    
}
