using Nc.Data.Network.Components;
using Nc.Data.Network.ComponentType;
using Nc.Data.Network.Location;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Domain.Repos.Network.Location;

namespace Nc.Domain.Network.Components;
public sealed class Switch(SwitchData? data) : ServerEntity<SwitchData>(data) {
    public int NumberOfPorts => _data.NumberOfPorts;
    public int ServerTypeId => _data.ServerTypeId;
    public async override Task LoadLazy(){
        await base.LoadLazy();

        var geographicPoints = await GetFromRepo.Items<IGeographicPointRepo, GeographicPoint>(nameof(GeographicPointData.Id), Id);
        GeographicPoints ??= (geographicPoints ?? Enumerable.Empty<GeographicPoint>())
        .Where(gp => gp.Id== Id)
        .ToList();

        var serverTypes = await GetFromRepo.Items<IServerTypeRepo, ServerType>(nameof(ServerTypeData.Id), Id);
        ServerTypes ??= (serverTypes ?? Enumerable.Empty<ServerType>())
        .Where(st => st.Id == Id)
        .ToList();

        ServerType ??= await GetFromRepo.Item<IServerTypeRepo, ServerType>(ServerTypeId);
    }
    public List<GeographicPoint>? GeographicPoints{ get; private set; }
    public List<ServerType>? ServerTypes { get; private set; }
    public ServerType? ServerType { get; private set; }
}
